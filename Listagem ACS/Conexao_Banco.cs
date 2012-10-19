using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Listagem_ACS
{
    public partial class Conexao_Banco : Form
    {
        FbConnection _fbConexao;
        FbDataAdapter _fbDataAdapter = new FbDataAdapter();
        DataTable _dtTable = new DataTable();
        public Conexao_Banco()
        {
            InitializeComponent();
        }

        private void Conexao_Banco_Load(object sender, EventArgs e)
        {

            string caminho = @"C:\Sistema de Registro da Producao Ambulatorial\FBCADASTRO_AGENDA.FDB";
            string conexao = "User=SYSDBA;"
                + "PassWord=masterkey;"
                + "DataBase=" + caminho;

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
            MostraTodos();

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
            _dtTable.Clear();
            string query = "SELECT * FROM TBUSUARIO WHERE CDUSUARIO = @codigo";
            _fbDataAdapter.SelectCommand = new FbCommand(query, _fbConexao);
            string codigo = "000000"+ tx_pesquisa.Text;
            _fbDataAdapter.SelectCommand.Parameters.Add("@codigo", FbDbType.VarChar);
            _fbDataAdapter.SelectCommand.Parameters[0].Value = codigo;
            _fbDataAdapter.Fill(_dtTable);

        }

        
    }
}
