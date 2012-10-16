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
    public partial class TelaInicial : Form
    {        
        string[] Areas;
        string[] Agentes;
        ArrayList ArrayRuas = new ArrayList();
        ArrayList ArrayAgentes = new ArrayList();
       
        public TelaInicial()
        {   
            InitializeComponent();            
            CarregaMicroareas();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            if (progressBar1.Value<100)
                progressBar1.Value += 1;

            if (progressBar1.Value == 20)
                lb_carregando.Text = "Carregando Lista de usuários...";

            if (progressBar1.Value == 40)
                lb_carregando.Text = "Carregando Lista de endereços...";

            if (progressBar1.Value == 60)
                lb_carregando.Text = "Carregando Movimentos...";
            
            if (progressBar1.Value == 90)
                lb_carregando.Text = "Finalizando...";



            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Visible = false;
                Menu_Principal inicio = new Menu_Principal(ArrayRuas, ArrayAgentes);
                inicio.ShowDialog();
                this.Close();                
                
            }
        }
        
        public void CarregaMicroareas()
        {
            Areas = File.ReadAllLines(@"Areas.csv");
            Agentes = File.ReadAllLines(@"Agentes.csv");                                    
            //ADICIONA ARRAY DE MICROAREAS, RUAS E NUMEROS
            for (int i = 0; i < Areas.Length; i++)
            {   
                ArrayRuas.Add(Areas[i].Split(';'));                
            }
            //ADINCIONA ARRAY AGENTES
            for (int i = 0; i < Agentes.Length; i++)
            {
                ArrayAgentes.Add(Agentes[i].Split(';'));
            }
        }
    }
}
