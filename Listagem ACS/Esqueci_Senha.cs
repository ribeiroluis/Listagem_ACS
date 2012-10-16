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
    public partial class Esqueci_Senha : Form
    {
        ArrayList ArrayUsuarios = new ArrayList();
        string[] Usuarios = File.ReadAllLines(@"Logon_Usuarios.txt");
        int Posicao;

        public Esqueci_Senha()
        {
            InitializeComponent();
            GravaArray();
        }

        private void GravaArray()
        {
            for (int i = 0; i < Usuarios.Length; i++)
            {
                ArrayUsuarios.Add(Usuarios[i].Split(';'));
            }

            string[] aux;
            for (int i = 0; i < ArrayUsuarios.Count; i++)
            {
                aux = (string [])ArrayUsuarios[i];
                if (aux[0].Length < 11)
                {
                    char[] PreencheChar = new char[11];
                    char[] auxChar = aux[0].ToCharArray();
                    int tamanho = aux[0].Length;
                    tamanho = 11 - tamanho;
                    for (int j = 0; j < tamanho; j++)
                    {
                        PreencheChar[j] = '0';
                    }
                    int k = 0;
                    for (int j = tamanho; j < 11; j++)
                    {                        
                        PreencheChar[j] = auxChar[k];
                        k++;
                    }
                    aux[0] = "";
                    for (int j = 0; j < 11; j++)
                    {
                        aux[0] += PreencheChar[j];
                    }
                    ArrayUsuarios[i] = aux;
                    
                }

            }
        }

        private void BuscaCPF()
        {
            string CPF = tx_CPF.Text;
            int i;
            Posicao = 0;
            for (i = 0; i < ArrayUsuarios.Count; i++)
            {
                string[] aux = (string[])ArrayUsuarios[i];
                if (CPF.Equals(aux[0]))                
                {
                    lb_NomeCPF.Text = aux[1];
                    lb_NomeCPF.Visible = true;
                    break;
                }
                Posicao++;
            }
            if (i == ArrayUsuarios.Count)
            {
                MessageBox.Show("Usuário não encontrado, verifique CPF", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lb_NomeCPF.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscaCPF();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_NomeCPF.Text.Equals("") || tx_SenhaNova.Text.Equals(""))
            {
                MessageBox.Show("Verifique informações", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (tx_SenhaNova.Text.Equals(tx_ConfirmarSenha.Text))
                {
                    string[] aux = (string[])ArrayUsuarios[Posicao];
                    aux[2] = tx_SenhaNova.Text;
                    ArrayUsuarios[Posicao] = aux;
                    GravaAlteracoes();
                    MessageBox.Show("Senha alterada com sucesso", "Ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha não confere", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
 
            }
        }
        private void GravaAlteracoes()
        {
            string [] aux;
            string patch = @"Logon_Usuarios.txt";
            StreamWriter file = new StreamWriter(patch, false);
            aux = (string[])ArrayUsuarios[0];
            file.WriteLine(aux[0]+";"+aux[1]+";"+aux[2]);
            file.Close();
            for (int i = 1; i < ArrayUsuarios.Count; i++)
            {
                using (StreamWriter file_2 = new StreamWriter(patch, true))
                {
                    aux = (string[])ArrayUsuarios[i];
                    file_2.WriteLine(aux[0] + ";" + aux[1] + ";" + aux[2]);
                    file_2.Close();
                }
 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
