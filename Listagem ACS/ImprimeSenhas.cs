using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listagem_ACS
{
    public partial class ImprimeSenhas : Form
    {
        public ImprimeSenhas()
        {
            InitializeComponent();
            MessageBox.Show("Nas propriedades de impressão\nselecione 16 páginas por folha!");
            crystalReportViewer1.Zoom(45); // aplica zoom da página em 45 %
        }
    }
}
