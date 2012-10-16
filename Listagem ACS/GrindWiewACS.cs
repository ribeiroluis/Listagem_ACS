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
    public partial class GrindWiewACS : Form
    {
        ArrayList Enderecos = new ArrayList();        
        
        public GrindWiewACS(string [] nomeAcs, ArrayList end)
        {            
            InitializeComponent();
            ACS_Recebido.Text = nomeAcs[1];
            Enderecos = end;
            ENF_Recebido.Text = nomeAcs[3];
            //Popula Grind View
            for (int i = 0;i<Enderecos.Count;i++)
            {
                int tamanho = 0;
                          
                string [] aux = (string [])Enderecos[i];
                for (int l = 2; l < aux.Length; l++)
                {
                    if (aux[l].Equals(""))
                        break;
                    else
                        tamanho++;
                }

                string[] auxOrdena = new string[tamanho];

                for (int k = 0; k < tamanho; k++)
                {   
                    auxOrdena[k] = aux[k + 2];
                }

                auxOrdena = Ordena(auxOrdena);
                int j = 0;
                string Numeros = "";
                do
                {
                    Numeros += (auxOrdena[j]+";");
                    j++;
                } while (j < auxOrdena.Length);
                DataGrindView_ACS.Rows.Add(aux[1], Numeros);
            }
        }
        
        
        public string [] Ordena(string [] ordenar)
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
    }
}
