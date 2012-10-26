using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data.Odbc;

namespace Listagem_ACS
{
    public partial class Conexao_Banco : Form
    {
        FbConnection _fbConexao;
        FbDataAdapter _fbDataAdapter = new FbDataAdapter();
        DataTable _dtTable = new DataTable();
        string codigo = "";
        string aux_codigo;
        string Retorna_nome;

        public Conexao_Banco(/*string _codigo*/)
        {
            InitializeComponent();

            aux_codigo = tx_pesquisa.Text;
            //this.aux_codigo = _codigo;
            /*string caminho = @"C:\Sistema de Registro da Producao Ambulatorial\FBCADASTRO_AGENDA.FDB";
            string conexao = "User=SYSDBA;"
                + "PassWord=masterkey;"
                + "DataBase=" + caminho;*/
            //DRIVER=Firebird/InterBase(r) driver;UID=SYSDBA;PWD=masterkey; DBNAME=MyServer/3051:C:\database\myData.fdb;
            // @"DataSource=localhost; Database=C:\PastaFireBird\BANCOFIREBIRD.FDB;";
            //User=SYSDBA; Password=masterkey; Database=D:\Meus Documentos\Faculdade - Esucri\Programação avançada I\Delphi com Banco\Banco\BANCO.FDB; DataSource=192.168.0.100;Dialect=3;PacketSize = 4096;" 
            string conexao = @"User=SYSDBA;Password=masterkey;Database=C:\Sistema de Registro da Producao Ambulatorial\FBCADASTRO_AGENDA.FDB;DataSource=RECEPCAO;Port=3050;Dialect=3;PacketSize=4096";



            _fbConexao = new FbConnection(conexao);
            
            try
            {
                _fbConexao.Open();

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
            dtgrd_view.DataSource = _dtTable;
            _fbConexao.Close();
            
        }

        private void Conexao_Banco_Load(object sender, EventArgs e)
        {

            

        }
        private void MostraTodos()
        {
            _dtTable.Clear();
            string query = "SELECT * FROM TBUSUARIO";
            _fbDataAdapter.SelectCommand = new FbCommand(query, _fbConexao);
            _fbDataAdapter.Fill(_dtTable);
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            MostraTodos();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
                     
        }

        public string Consulta()
        {
            string nada = "";
            try
            {
                _dtTable.Clear();
                string query = "SELECT * FROM TBUSUARIO WHERE CDUSUARIO = @codigo";
                _fbDataAdapter.SelectCommand = new FbCommand(query, _fbConexao);

                //aux_codigo = tx_pesquisa.Text;
                int tamanho = 7 - (aux_codigo.Length);
                for (int i = 0; i < tamanho; i++)
                {
                    codigo += '0';
                }
                codigo += aux_codigo;
                _fbDataAdapter.SelectCommand.Parameters.Add("@codigo", FbDbType.VarChar);
                _fbDataAdapter.SelectCommand.Parameters[0].Value = codigo;
                _fbDataAdapter.Fill(_dtTable);

                string _Nome = dtgrd_view.CurrentRow.Cells[2].Value.ToString();

                DateTime _data = (DateTime)dtgrd_view.CurrentRow.Cells[5].Value;
                DateTime _datahoje = new DateTime();
                Convert.ToDateTime(_data);
                _datahoje = DateTime.Now;
                int x = _datahoje.Year;
                int y = _data.Year;
                string _Idoso = "";
                if ((x - y) > 59)
                {
                    _Idoso = " - IDOSO";
                }

                codigo = "";
                aux_codigo = "";
                Retorna_nome = _Nome + _Idoso;
                return Retorna_nome;
                _fbConexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("PRONTUÁRIO NÃO ENCONTRADO \n\n"+ erro.ToString());
                _fbConexao.Close();
                return nada;
            }
        }
    }
}
