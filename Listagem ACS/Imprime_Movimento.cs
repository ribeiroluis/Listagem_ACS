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
using System.Xml.Linq;

namespace Listagem_ACS
{
    public partial class Imprime_Movimento : Form
    {
        ArrayList Movimento_consultado = new ArrayList();

        string[] _Movimento = File.ReadAllLines(@"Movimento_bkp.csv");
        //string[] _Movimento = File.ReadAllLines(@"c:\Listagem ACS\Movimento_bkp.csv");
        string[] _Medicos = File.ReadAllLines(@"Medicos.csv");

        public Imprime_Movimento()
        {
            InitializeComponent();
            PreencheCheckBox();
        }
        private void PreencheCheckBox()
        {
            for (int i = 0; i < _Medicos.Length; i++)
            {
                string[] aux = _Medicos[i].Split(';');
                cb_medicos.Items.Add(aux[1]);
                //list_checked.Items.Add(aux[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;

            Movimento_consultado.Clear();
            for (int i = 1; i < _Movimento.Length; i++)
            {
                string[] aux = _Movimento[i].Split(';');
                string aux_medico = cb_medicos.SelectedItem.ToString();
                string aux_data = calen_date.Value.ToShortDateString();

                if (aux[4].Equals(aux_medico) && aux[3].Equals(aux_data))
                {
                    Movimento_consultado.Add(aux);
                }
            }

            if (Movimento_consultado.Count < 1)
            {
                MessageBox.Show("Não há movimento para este dia ou médico");
            }
            else
            {
                MessageBox.Show("Você será redirecionado para impressão");
                Ordena_Array();
                
                Grava_xml_Movimento();               

                Relatorio_Impresso imprime = new Relatorio_Impresso();
                imprime.ShowDialog();

                MessageBox.Show("Você será direcionado para \n imprimir as senhas");
                Grava_xml_Senhas();
                ImprimeSenhas imprimeSenha = new ImprimeSenhas();
                imprimeSenha.ShowDialog();

            }
        }
        private void Grava_xml_Movimento()
        {
            string NomeArquivo = @"C:\movimento_impresso.xml";
            XElement Movimento_XML = new XElement("movimento");

            for (int i = 0; i < Movimento_consultado.Count; i++)
            {
                string [] aux = (string []) Movimento_consultado[i];
                // Adiciona Elemento XML
                Movimento_XML.Add(new XElement("Paciente", new XElement("Numero", (i+1)), new XElement("Pronturario",aux[0]), new XElement("Nome", aux[1]), new XElement("Hora",aux[2]),new XElement("Data",aux[3]),new XElement("Medico",aux[4])));

                
            }
            Movimento_XML.Save(NomeArquivo);// Salva o Arquivo*/            
            //File.Copy(@"movimento_impresso.xml", @"C:\LISTAGEM ACS\movimento_impresso.xml", true);
            MessageBox.Show("Movimento criado com Sucesso!");
        }

        private void Grava_xml_Senhas()
        {
            string Especialidade = "";

            for (int i = 0; i < _Medicos.Length; i++)
            {
                string[] aux_Movimento = (string[])Movimento_consultado[0];
                string [] aux_medicos = _Medicos[i].Split(';');
                if(aux_Movimento[4].Equals(aux_medicos[1]))                
                {
                    Especialidade = aux_medicos[0];
                    break;
                }
            }

            string NomeArquivo = @"C:\Senhas_Individual.xml";
            XElement Movimento_XML = new XElement("Movimento");

            for (int i = 0; i < Movimento_consultado.Count; i++)
            {
                string[] aux = (string[])Movimento_consultado[i];
                // Adiciona Elemento XML
                Movimento_XML.Add(new XElement("Senha",new XElement("Numero",(i+1)) ,new XElement("Data",aux[3]), new XElement("Medico", aux[4]), new XElement("Especialidade", Especialidade)));


            }
            Movimento_XML.Save(NomeArquivo);// Salva o Arquivo*/            
            //File.Copy(@"movimento_impresso.xml", @"C:\LISTAGEM ACS\movimento_impresso.xml", true);
            MessageBox.Show("Senhas criadas com Sucesso!");
 
        }





        private void Ordena_Array()
        {
            ArrayList auxArray = new ArrayList();
            for (int i = 0; i < Movimento_consultado.Count - 1; i++)
            {
                for (int j = i + 1; j < Movimento_consultado.Count; j++)
                {
                    string[] aux_i = (string[])Movimento_consultado[i];
                    string[] aux_j = (string[])Movimento_consultado[j];
                    int x = aux_i[2].CompareTo(aux_j[2]);

                    if (x > 0)
                    {
                        string[] aux = (string[])Movimento_consultado[i];
                        Movimento_consultado[i] = Movimento_consultado[j];
                        Movimento_consultado[j] = aux;
                        
                    }
                }
            }
        }

        private void cb_medicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
}