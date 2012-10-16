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
    public partial class Movimento_Diario : Form
    {        
        ArrayList Usuarios_Antigos = new ArrayList();
        ArrayList Registro = new ArrayList();
        string [] file = File.ReadAllLines(@"Usuarios_Antigos.csv");
        
        public Movimento_Diario()
        {
            InitializeComponent();
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            for (int i = 0; i < file.Length; i++)
            {
                string[] aux = file[i].Split(';');
                Usuarios_Antigos.Add(aux);
            }
        }

        private void tx_Prontuario_TextChanged(object sender, EventArgs e)
        {

            if (radio_Antigo.Checked == true)
            {

                tx_Nome.Clear();
                label_tollstrip.Text = "Carregando...";
                int somar = 0;
                for (int i = 0; i < Usuarios_Antigos.Count; i++)
                {
                    somar++;
                    string[] aux = (string[])Usuarios_Antigos[i];
                    if (aux[1].Equals(tx_Prontuario.Text))
                    {
                        tx_Nome.Text = aux[0];
                        break;
                    }

                    if (somar >= (Usuarios_Antigos.Count * 0.01))
                    {
                        somar = 0;
                        progressBar_tollstrip.Value = +1;
                    }
                }
                progressBar_tollstrip.Value = 0;
                label_tollstrip.Text = "...";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_Prontuario.Clear();
            tx_Nome.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Painel_RegistraMovimento.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] aux = new string[5];
                aux[0] = tx_Prontuario.Text;
                aux[1] = tx_Nome.Text;
                aux[2] = cb_Medicos.SelectedItem.ToString();
                aux[3] = date_DataConsulta.Value.Day.ToString() + "/" + date_DataConsulta.Value.Month.ToString() + "/" + date_DataConsulta.Value.Year.ToString();
                aux[4] = cb_Horas.SelectedItem.ToString();
                Registro.Add(aux);
                DataGrind_Registro.Rows.Add(aux[0], aux[1], aux[2], aux[3], aux[4]);
                button1_Click(sender, e);

            }
            catch (Exception er)
            {

                MessageBox.Show(er.ToString());
            }

        }        
        
    }
}
