using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Listagem_ACS
{
    struct Pacientes
    {
        public string _Prontuario;
        public string _Nome;
    }

    public partial class Movimento_Diario : Form
    {

        Pacientes Obj_p;
        List<Pacientes> Lista_Pacientes = new List<Pacientes>();
        ArrayList Medicos_Array = new ArrayList();
        int item = 0;
        ArrayList Preenche_grade = new ArrayList();

        string[] _Arquivo_recebido = File.ReadAllLines(@"Cadastro.csv", Encoding.Default);

        public Movimento_Diario()
        {
            InitializeComponent();
            Carrega_tabela();
            Preenche_combobox();

        }
        private void Carrega_tabela()
        {
            for (int i = 0; i < _Arquivo_recebido.Length; i++)
            {
                string[] aux = _Arquivo_recebido[i].Split(';');
                Obj_p._Prontuario = aux[1];
                Obj_p._Nome = aux[0];
                Lista_Pacientes.Add(Obj_p);
            }

            string[] _Medicos = File.ReadAllLines(@"Medicos.csv");
            for (int i = 0; i < _Medicos.Length; i++)
            {
                string[] aux = _Medicos[i].Split(';');
                Medicos_Array.Add(aux);
            }
        }

        private void Preenche_combobox()
        {
            for (int i = 0; i < Medicos_Array.Count; i++)
            {
                string[] aux = (string[])Medicos_Array[i];
                cb_medicos.Items.Add(aux[1]);
            }
        }

        private void cb_medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_horario.Items.Clear();
            cb_horario.ResetText();
            string[] aux = { "", "" };
            for (int i = 0; i < Medicos_Array.Count; i++)
            {
                aux = (string[])Medicos_Array[i];
                if (aux[1].Equals(cb_medicos.SelectedItem.ToString()))
                    break;
            }

            for (int i = 2; i < aux.Length; i++)
            {
                if (!aux[i].Equals(""))
                    cb_horario.Items.Add(aux[i]);
            }


        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                string[] aux = new string[5];
                item++;
                ListViewItem lista = new ListViewItem(item.ToString());
                lista.SubItems.Add(tx_prontuario.Text);
                aux[0] = tx_prontuario.Text;
                lista.SubItems.Add(tx_nome.Text.ToUpper());
                aux[1] = tx_nome.Text.ToUpper();
                lista.SubItems.Add(cb_horario.SelectedItem.ToString());
                aux[2] = cb_horario.SelectedItem.ToString();
                lista.SubItems.Add(cb_date.Value.ToShortDateString());
                aux[3] = cb_date.Value.ToShortDateString();
                lista.SubItems.Add(cb_medicos.SelectedItem.ToString().ToUpper());
                aux[4] = cb_medicos.SelectedItem.ToString().ToUpper(); ;
                grade_listview.Items.Add(lista);
                Preenche_grade.Add(aux);
                tx_nome.Clear();
                tx_prontuario.Clear();

            }
            catch (Exception erro)
            {
                
                MessageBox.Show(erro.ToString());
            }
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                grade_listview.Items.Clear();
                item = 0;
                Preenche_grade.RemoveAt(Preenche_grade.Count - 1);
                for (int i = 0; i < Preenche_grade.Count; i++)
                {
                    item++;
                    string[] aux = (string[])Preenche_grade[i];
                    ListViewItem lista = new ListViewItem(item.ToString());
                    lista.SubItems.Add(aux[0]);//prontuario
                    lista.SubItems.Add(aux[1]);//nome
                    lista.SubItems.Add(aux[2]);//horario
                    lista.SubItems.Add(aux[3]);//data
                    lista.SubItems.Add(aux[4]);//medico
                    grade_listview.Items.Add(lista);
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (Preenche_grade.Count == 0)
            {
                MessageBox.Show("Não há movimento lançado");

            }
            else
            {

                string Arquivo = @"Movimento_bkp.csv";
                for (int i = 0; i < Preenche_grade.Count; i++)
                {
                    string[] aux = (string[])Preenche_grade[i];
                    using (StreamWriter file_ = new StreamWriter(Arquivo, true))
                    {
                        file_.WriteLine(aux[0] + ";" + aux[1] + ";" + aux[2] + ";" + aux[3] + ";" + aux[4]);
                        file_.Close();
                    }
                }
                MessageBox.Show("Gravado com sucesso!!");
                this.Close();
            }
        }
    }
}
