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
    public partial class Menu_Principal : Form
    {
        ArrayList ArrayRuas = new ArrayList();
        ArrayList ArrayACS = new ArrayList();        

        public Menu_Principal(ArrayList Ruas, ArrayList ACS)
        {
            InitializeComponent();
            ArrayRuas = Ruas;
            ArrayACS = ACS;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enderecos end = new Enderecos(ArrayRuas,ArrayACS);
            end.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaEndereçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movimento_Diario mov = new Movimento_Diario();
            mov.ShowDialog();
        }
        

        private void consultaProcedimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProcedimento consulta = new ConsultaProcedimento();            
            consulta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Imprime_Movimento imp = new Imprime_Movimento();
            imp.ShowDialog();
        }
    }
}
