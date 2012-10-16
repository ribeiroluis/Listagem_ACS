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
    public partial class Enderecos : Form
    {
        //string[] Areas;
        //string[] Agentes;
        ArrayList ArrayRuas= new ArrayList();
        ArrayList ArrayAgentes = new ArrayList();
       
        public Enderecos(ArrayList Ruas, ArrayList ACS)
        {   
            InitializeComponent();
            ArrayRuas = Ruas;
            ArrayAgentes = ACS;
            CarregaLista();
        }
        private void CarregaLista()
        {
            string[] aux;
            
            //ADICIONA NOMES DOS AGENTES NA COMBOBOX;
            ArrayAgentes = Ordena(); //Ordena array
            for (int i = 0; i < ArrayAgentes.Count; i++)
            {
                aux = (string[])ArrayAgentes[i];
                cb_ACS.Items.Add(aux[1]);
            }

            //Adiciona ruas na combobox
             aux = (string[])ArrayRuas[0];
             cb_Rua.Items.Add(aux[1]);

            for (int i = 1; i < ArrayRuas.Count; i++)
            {
                int count = 0;
                aux = (string[])ArrayRuas[i];
                
                //remove os itens iguais
                for (int j = 0; j<cb_Rua.Items.Count;j++)
                {
                    if (aux[1].Equals(cb_Rua.Items[j]))
                    {
                        count++;                        
                    }
                }
                if (count == 0)
                {
                    cb_Rua.Items.Add(aux[1]);
                }
            }

            
        }
        
        //Ordena Array Agentes
        public ArrayList Ordena()
        {
            ArrayList auxiliar = ArrayAgentes;
            for (int i = 0; i < ArrayAgentes.Count; i++)
            {
                string[] AuxiliarStringI = (string[])auxiliar[i];
                for (int j = 0; j < ArrayAgentes.Count - 1; j++)
                {
                    string[] AuxiliarStringJ = (string[])auxiliar[j];
                    if (AuxiliarStringI[1].CompareTo(AuxiliarStringJ[1]) < 0)
                    {
                        string[] aux = (string[])auxiliar[i];
                        auxiliar[i] = auxiliar[j];
                        auxiliar[j] = aux;
                    }
 
                }
            }
            return auxiliar;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                ArrayList RuasListadas = new ArrayList();
                ArrayList ACSListados = new ArrayList();
                //string Enfermeiro;

                string Rua = cb_Rua.SelectedItem.ToString();

                //Localiza Ruas
                for (int i = 0; i < ArrayRuas.Count; i++)
                {
                    string[] aux = (string[])ArrayRuas[i];
                    if (Rua.Equals(aux[1]))
                        RuasListadas.Add(aux);
                }

                //Localiza ACS
                for (int i = 0; i < RuasListadas.Count; i++)
                {
                    string[] aux = (string[])RuasListadas[i];
                    for (int j = 0; j < ArrayAgentes.Count; j++)
                    {
                        string[] agente = (string[])ArrayAgentes[j];
                        if (aux[0].Equals(agente[0]))
                        {
                            ACSListados.Add(ArrayAgentes[j]);
                            break;
                        }
                    }

                }

                GrindViewRua ruas = new GrindViewRua(ACSListados, RuasListadas);
                ruas.ShowDialog();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Microarea = "";
                string ACSComboBox= cb_ACS.SelectedItem.ToString();
                string[] NomeACS = (string[])ArrayAgentes[0];
                ArrayList Enderecos = new ArrayList();

                //Localiza a microarea o item selecionado no combobox
                for (int i = 0; i < ArrayAgentes.Count; i++)
                {
                    string[] aux = (string[])ArrayAgentes[i];
                    if (ACSComboBox.Equals(aux[1]))
                        Microarea = aux[0];
                }

                //Localiza ACS
                for (int i = 0; i < ArrayAgentes.Count; i++)
                {
                    string[] aux = (string[])ArrayAgentes[i];
                    if (ACSComboBox.Equals(aux[1]))
                        NomeACS = aux;
                }


                for (int i = 0; i < ArrayRuas.Count; i++)
                {
                    string[] aux = (string[])ArrayRuas[i];
                    if (Microarea.Equals(aux[0]))
                        Enderecos.Add(aux);

                }


                GrindWiewACS grind = new GrindWiewACS(NomeACS, Enderecos);
                grind.ShowDialog();

            }
            catch (Exception x)
            {

                MessageBox.Show(x.ToString(),"Atenção" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        
    }
}
