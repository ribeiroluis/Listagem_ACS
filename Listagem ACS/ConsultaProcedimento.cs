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
    public partial class ConsultaProcedimento : Form
    {
        ArrayList arrayGrupo = new ArrayList();
        ArrayList arraySubGrupo = new ArrayList();
        ArrayList arrayFormaOrganizacao = new ArrayList();
        ArrayList arrayProcedimentos = new ArrayList();

        public ConsultaProcedimento()
        {
            InitializeComponent();
            CarregaTabelasGrupo();
        }
        private void CarregaTabelasGrupo()
        {

            //Le as linhas do texto 
            string aux;
            string auxTexto;
            string[] Grupos = File.ReadAllLines(@"tb_grupo.txt", Encoding.Default);
            for (int i = 0; i < Grupos.Length; i++)
            {
                int j = 0;
                aux = Grupos[i];
                auxTexto = "";
                do
                {
                    auxTexto += aux[j];
                    j++;
                } while (j < 2);
                auxTexto += ';';

                for (int k = j; k < aux.Length; k++)
                {
                    auxTexto += aux[k];
                    if (aux[k + 1].Equals(' ') && aux[k + 2].Equals(' '))
                        break;
                }
                arrayGrupo.Add(auxTexto.Split(';'));
            }

            //Le as linhas do texto             
            string[] SubGrupos = File.ReadAllLines(@"tb_sub_grupo.txt", Encoding.Default);
            for (int i = 0; i < SubGrupos.Length; i++)
            {
                int j = 0;
                aux = SubGrupos[i];
                auxTexto = "";
                do
                {
                    auxTexto += aux[j];
                    j++;
                } while (j < 4);
                auxTexto += ';';

                for (int k = j; k < aux.Length; k++)
                {
                    auxTexto += aux[k];
                    if (aux[k + 1].Equals(' ') && aux[k + 2].Equals(' '))
                        break;
                }
                arraySubGrupo.Add(auxTexto.Split(';'));
            }

            //le formas de organizacao
            string[] FormasdeOrganizacao = File.ReadAllLines(@"tb_forma_organizacao.txt", Encoding.Default);
            for (int i = 0; i < FormasdeOrganizacao.Length; i++)
            {
                int j = 0;
                aux = FormasdeOrganizacao[i];
                auxTexto = "";
                do
                {
                    auxTexto += aux[j];
                    j++;
                } while (j < 6);
                auxTexto += ';';

                for (int k = j; k < aux.Length; k++)
                {
                    auxTexto += aux[k];
                    if (aux[k + 1].Equals(' ') && aux[k + 2].Equals(' '))
                        break;
                }
                arrayFormaOrganizacao.Add(auxTexto.Split(';'));
            }

            //le procedimentos
            string[] Procedimentos = File.ReadAllLines(@"tb_procedimento.txt", Encoding.Default);
            for (int i = 0; i < Procedimentos.Length; i++)
            {
                int j = 0;
                aux = Procedimentos[i];
                auxTexto = "";
                do
                {
                    auxTexto += aux[j];
                    j++;
                } while (j < 10);
                auxTexto += ';';

                for (int k = j; k < aux.Length; k++)
                {
                    auxTexto += aux[k];
                    if (aux[k + 1].Equals(' ') && aux[k + 2].Equals(' '))
                        break;
                }
                arrayProcedimentos.Add(auxTexto.Split(';'));
            }



            cb_Grupo.Items.Add("");
            for (int i = 0; i < arrayGrupo.Count; i++)
            {
                string[] auxiliarCombobox = (string[])arrayGrupo[i];
                cb_Grupo.Items.Add(auxiliarCombobox[0] + " - " + auxiliarCombobox[1]);
            }

        }

        private void cb_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cb_subGrupo.Items.Clear();
                cb_subGrupo.ResetText();
                LimpaListview();

                cb_FormasdeOrganizacao.Items.Clear();
                cb_FormasdeOrganizacao.ResetText();
                string Selecionado = cb_Grupo.SelectedItem.ToString();
                tx_procedimento.Text = "";
                tx_procedimento.Text += Selecionado[0];
                tx_procedimento.Text += Selecionado[1];
                cb_subGrupo.Items.Add("");
                for (int i = 0; i < arraySubGrupo.Count; i++)
                {
                    string[] AuxSubGrupo = (string[])arraySubGrupo[i];
                    string StringAuxSubGrupo = AuxSubGrupo[0];
                    string StringAuxSubGrupo00 = "";
                    StringAuxSubGrupo00 += StringAuxSubGrupo[0];
                    StringAuxSubGrupo00 += StringAuxSubGrupo[1];
                    if (StringAuxSubGrupo00.Equals(tx_procedimento.Text))
                        cb_subGrupo.Items.Add(AuxSubGrupo[0] + " - " + AuxSubGrupo[1]);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione o Grupo", "Atenção");

            }


        }

        private void cb_subGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cb_FormasdeOrganizacao.Items.Clear();
                cb_FormasdeOrganizacao.ResetText();
                LimpaListview();

                string Selecionado = cb_subGrupo.SelectedItem.ToString();
                tx_procedimento.Text = "";
                tx_procedimento.Text += Selecionado[0];
                tx_procedimento.Text += Selecionado[1];
                tx_procedimento.Text += Selecionado[2];
                tx_procedimento.Text += Selecionado[3];
                cb_FormasdeOrganizacao.Items.Add("");
                for (int i = 0; i < arrayFormaOrganizacao.Count; i++)
                {
                    string[] AuxFormadeOrganizacao = (string[])arrayFormaOrganizacao[i];
                    string StringAuxFormadeOrganizacao = AuxFormadeOrganizacao[0];
                    string StringAuxFormadeOrganizacao00 = "";
                    for (int k = 0; k < StringAuxFormadeOrganizacao.Length - 2; k++)
                    {
                        StringAuxFormadeOrganizacao00 += StringAuxFormadeOrganizacao[k];
                    }

                    if (StringAuxFormadeOrganizacao00.Equals(tx_procedimento.Text))
                        cb_FormasdeOrganizacao.Items.Add(AuxFormadeOrganizacao[0] + " - " + AuxFormadeOrganizacao[1]);

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Selecione o Sub Grupo", "Atenção");
            }

        }

        private void cb_FormasdeOrganizacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimpaListview();
                string Selecionado = cb_FormasdeOrganizacao.SelectedItem.ToString();
                tx_procedimento.Text = "";
                for (int k = 0; k < 6; k++)
                {
                    tx_procedimento.Text += Selecionado[k];
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione o Sub Grupo", "Atenção");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_FormasdeOrganizacao.Items.Clear();
            cb_FormasdeOrganizacao.ResetText();
            cb_subGrupo.Items.Clear();
            cb_subGrupo.ResetText();
            tx_procedimento.Text = "";
            cb_subGrupo.ResetText();
            LimpaListview();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int impar = 1;
                LimpaListview();

                if (!tx_NomeProcedimento.Text.Equals(""))
                {

                }
                else
                {
                    for (int i = 0; i < arrayProcedimentos.Count; i++)
                    {
                        string[] auxProcedimentos = (string[])arrayProcedimentos[i];
                        string auxProcedimento00 = auxProcedimentos[0];
                        string auxCodProced = "";
                        for (int j = 0; j < tx_procedimento.Text.Length; j++)
                        {
                            auxCodProced += auxProcedimento00[j];
                        }

                        if (auxCodProced.Equals(tx_procedimento.Text))
                        {
                            string codProcedimento = "";
                            int k = 0;
                            do
                            {
                                codProcedimento += auxProcedimento00[k];
                                k++;
                                if (k == 2 || k == 4 || k == 6)
                                    codProcedimento += '.';

                                if (k == 9)
                                    codProcedimento += '-';

                            } while (k < auxProcedimento00.Length);

                            ListViewItem list = new ListViewItem(codProcedimento);
                            if (impar % 2 == 1)
                                list.BackColor = Color.LightGray;
                            list.SubItems.Add(auxProcedimentos[1]);
                            lv_CodigoNome.Items.Add(list);
                            impar++;
                        }
                    }
                    if (lv_CodigoNome.Items.Count == 0)
                        MessageBox.Show("Nenhum procedimento encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString(), "Atenção");
            }
        }

        private void LimpaListview()
        {
            lv_CodigoNome.Items.Clear();
        }
    }
}
