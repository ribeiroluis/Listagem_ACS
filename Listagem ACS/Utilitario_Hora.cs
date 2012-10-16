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
    public partial class Utilitario_Hora : Form
    {
        public Utilitario_Hora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string AuxHoraTrabalhou = "";
                string AuxHoraJornada = "";
                int Jornada = (int.Parse(Jornada_hora.Text) / 100) * 60;

                int Entrada1 = CalculaHora(Entrada_1.Text);
                int Entrada2 = CalculaHora(Entrada_2.Text);
                int Saida1 = CalculaHora(Saida_1.Text);
                int Saida2 = CalculaHora(Saida_2.Text);

                int diferenca = (Entrada2 - Entrada1) + (Saida2 - Saida1);
                int hora = diferenca / 60;
                int min = (diferenca % 60);

                int Saldo = diferenca - Jornada;
                int horasaldo = (Saldo / 60) * -1;
                int minsaldo = (Saldo % 60) * -1;

                if (Saldo < 0)
                {
                    saldo_Hora.ForeColor = Color.Red;
                    Label_Saldo.Text = "Débido";
                    Label_Saldo.ForeColor = Color.Red;
                }
                else
                {
                    saldo_Hora.ForeColor = Color.Blue;
                    Label_Saldo.Text = "Crédito";
                    Label_Saldo.ForeColor = Color.Blue;
                }


                if (hora < 10)
                {
                    AuxHoraTrabalhou += 0;

                }

                if (horasaldo < 10)
                {
                    AuxHoraJornada += 0;

                }
                AuxHoraJornada += horasaldo;
                AuxHoraJornada += minsaldo;

                AuxHoraTrabalhou += hora;
                AuxHoraTrabalhou += min;
                Resutado_hora.Text = AuxHoraTrabalhou;
                saldo_Hora.Text = AuxHoraJornada;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
            
            
            
        }

        private int CalculaHora(string entrada)
        {
            int hora;
            string aux1 = "";
            string aux2 = "";
            for (int i = 0; i < entrada.Length; i++)
            {
                if (i < 2)
                    aux1 += entrada[i];
                else
                    aux2 += entrada[i];
            }

            hora = (int.Parse(aux1) * 60) + int.Parse(aux2);

            return hora;
            

        }
    }
}
