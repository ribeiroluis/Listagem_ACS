using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Listagem_ACS
{
    public partial class GrindViewRua : Form
    {
        ArrayList ACSRecebido = new ArrayList();
        ArrayList RuasRecebidas = new ArrayList();

        public GrindViewRua(ArrayList ACS, ArrayList Ruas)
        {
            InitializeComponent();
            ACSRecebido = ACS;
            RuasRecebidas = Ruas;
            for (int i = 0; i < ACSRecebido.Count; i++)
            {
                string[] auxRuas = (string[])RuasRecebidas[i];
                string[] auxAcs = (string[])ACSRecebido[i];

                int tamanho = 0;
                for (int l = 2; l < auxRuas.Length; l++)
                {
                    if (auxRuas[l].Equals(""))
                        break;
                    else
                        tamanho++;
                }

                string[] auxOrdena = new string[tamanho];

                for (int k = 0; k < tamanho; k++)
                {
                    auxOrdena[k] = auxRuas[k + 2];
                }

                auxOrdena = Ordena(auxOrdena);
                
                int j = 0; string Numeros = "";               
                
                do
                {
                    Numeros += (auxOrdena[j] + ";");
                    j++;
                } while (j < auxOrdena.Length);

                Grind_Ruas.Rows.Add(auxAcs[1], Numeros);
            }
            string[] RuaRecebidaTitulo = (string[])RuasRecebidas[0];
            lb_Rua.Text = RuaRecebidaTitulo[1];

        }
        public string[] Ordena(string[] ordenar)
        {

            for (int i = 0; i < ordenar.Length; i++)
            {
                int a = int.Parse(ordenar[i]);
                for (int j = 0; j < ordenar.Length - 1; j++)
                {
                    int b = int.Parse(ordenar[j]);

                    if (a < b)
                    {
                        string aux = ordenar[i];
                        ordenar[i] = ordenar[j];
                        ordenar[j] = aux;
                    }

                }
            }
            return ordenar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grind_Ruas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
