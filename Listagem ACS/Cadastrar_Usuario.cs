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
    public partial class Cadastrar_Usuario : Form
    {
        string[] Prontuarios_Recebidos;
        string[] Areas_Recebidas;
        string[] Agentes_Recebidos;        

        ArrayList Usuarios_Antigo = new ArrayList();
        ArrayList Usuarios_Novo = new ArrayList();
        ArrayList Ruas = new ArrayList();

        bool status = false;
        int Posicao_Novo, Posicao_Antigo;


        public Cadastrar_Usuario()
        {
            InitializeComponent();
            CarregaTabela();

        }

        //Botao sair e salvar
        private void button1_Click(object sender, EventArgs e)
        {
            if (botao_sair.Text == "Sair")
            {

                DialogResult resultado = MessageBox.Show("Você deseja realmente sair e salvar", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    label_toolstrip.Visible = true;
                }
                if (resultado == DialogResult.No)
                {
                    botao_editar.Enabled = true;
                    botao_sair.Enabled = false;
                    botao_editar.Text = "Editar";
                }
            }

            
        }

        //Metodo para preencher as tabelas de auxilio
        private void CarregaTabela()
        {
            //Recebe as linhas do arquivo de prontuarios
            Prontuarios_Recebidos = File.ReadAllLines(@"Cadastro_Usuarios.csv");
            
            //Recebe as linhas do arquivo de endereco
            Areas_Recebidas = File.ReadAllLines(@"Areas.csv");
            
            //funcao para preencher os enderecos na combobox e na memoria
            Preenche_Enderecos();

            //Recebe areas e Agentes
            Agentes_Recebidos = File.ReadAllLines(@"Agentes.csv");
            

            //Carrega para memoria primaria os prontuarios
            for (int i = 0; i < Prontuarios_Recebidos.Length; i++)
            {
                //vetor de auxilio para inserir os prontuarios
                string[] aux = Prontuarios_Recebidos[i].Split(';');
                
                //vetor de auxilio para preencher data de nascimento no formato 00/00/0000
                string[] data_Nascimento = aux[5].Split('/');
                
                //rotina para preenchimento de data
                if (data_Nascimento[0].Length < 2)
                {
                    data_Nascimento[0] = "0" + data_Nascimento[0];
                }
                if (data_Nascimento[1].Length < 2)
                {
                    data_Nascimento[1] = "0" + data_Nascimento[1];
                }
                string auxDataNascimento = "";
                for (int k = 0; k < 3; k++)
                {
                    auxDataNascimento += data_Nascimento[k];
                }
                aux[5] = auxDataNascimento;

                //se prontuario novo ou antigo adiciona na memoria primaria
                if (aux[0].Equals("N"))
                    Usuarios_Novo.Add(aux);
                else
                    Usuarios_Antigo.Add(aux);
            }

        }

        //Busca se há usuarios cadastrados
        private void tx_Prontuario_TextChanged(object sender, EventArgs e)
        {            
            //habilita o label toolstrip para informações se encontrou ou nao usuário cadastrado
            label_toolstrip.Visible = true;
            label_toolstrip.ForeColor = Color.Black;
            label_toolstrip.Text = "";
            botao_editar.Enabled = false;
            botao_inserir.Enabled = false;

            //Apaga os dados do form para que a consulta fique mais limpa
            tx_Nome.Clear();
            tx_CartaoSus.Clear();
            tx_Complemento.Clear();
            tx_Bairro.Clear();
            tx_Numero.Clear();
            tx_Telefone.Clear();
            cb_Enderecos.Items.Clear();
            cb_Enderecos.ResetText();
            tx_ACS.Clear();
            tx_Microarea.Clear();
            tx_data.Clear();

            //se usuarios novos selecionados procura em usuarios novos
            if (radio_Novo.Checked == true)
            {
                label_toolstrip.Text = "Carregando...";
                int somar = 0;
                for (int i = 0; i < Usuarios_Novo.Count; i++)
                {
                    somar++;
                    string[] aux = (string[])Usuarios_Novo[i];
                    if (aux[1].Equals(tx_Prontuario.Text))
                    {                        
                        Posicao_Novo = i;
                        
                        //comun aos dois prontuarios
                        cb_Enderecos.Items.Clear();
                        tx_CartaoSus.Text = aux[2];
                        tx_Nome.Text = aux[3];
                        tx_Telefone.Text = aux[4];
                        tx_data.Text = aux[5];
                        cb_Enderecos.Items.Add(aux[6]);
                        cb_Enderecos.SelectedItem = aux[6];
                        tx_Numero.Text = aux[7];
                        tx_Complemento.Text = aux[8];
                        tx_Bairro.Text = aux[9];                        

                        //bloqueia as caixas de texto para não haver modificações                        
                        tx_CartaoSus.ReadOnly = true;
                        tx_Bairro.ReadOnly = true;
                        tx_Nome.ReadOnly = true;
                        tx_Telefone.ReadOnly = true;
                        tx_Numero.ReadOnly = true;
                        tx_Complemento.ReadOnly = true;
                        cb_Enderecos.IsAccessible = false;
                        tx_data.ReadOnly = true;
                        status = true;
                        break;
                    }

                    if (somar >= (Usuarios_Novo.Count * 0.01))
                    {
                        somar = 0;
                        progressBar_toolstrip.Value = +1;
                    }
                }
                progressBar_toolstrip.Value = 0;
                
                //se nao localizar nenhum nome, gera nao localizado e libera o botao inserir
                if (tx_Nome.Text.Equals(""))
                {
                    label_toolstrip.ForeColor = Color.Red;
                    label_toolstrip.Text = "Não Localizado!";
                    botao_inserir.Enabled = true;                    
                    status = false;
                    Preenche_Enderecos();
                }
                    //senão libera botao editar para possivel alteração
                else
                {
                    label_toolstrip.Text = "Cadastrado!";
                    botao_inserir.Enabled = false;
                }
            }
            
                //else da condição se (linha 103)      
            else
            {
                label_toolstrip.Text = "Carregando...";
                int somar = 0;
                for (int i = 0; i < Usuarios_Antigo.Count; i++)
                {
                    somar++;
                    string[] aux = (string[])Usuarios_Antigo[i];
                    if (aux[1].Equals(tx_Prontuario.Text))
                    {
                        Posicao_Antigo = i;
                        tx_CartaoSus.Text = aux[2];
                        tx_Nome.Text = aux[3];
                        tx_Telefone.Text = aux[4];
                        tx_data.Text = aux[5];
                        tx_Numero.Text = aux[7];
                        tx_Complemento.Text = aux[8];
                        tx_Bairro.Text = aux[9];

                        tx_CartaoSus.Enabled = false;
                        tx_Bairro.Enabled = false;
                        tx_Nome.Enabled = false;
                        tx_Telefone.Enabled = false;
                        tx_Numero.Enabled = false;
                        tx_Complemento.Enabled = false;
                        cb_Enderecos.Enabled = false;
                        tx_data.Enabled = false;
                        status = true;
                        break;
                    }
                    if (somar >= (Usuarios_Antigo.Count * 0.01))
                    {
                        somar = 0;
                        progressBar_toolstrip.Value = +1;
                    }
                }
                progressBar_toolstrip.Value = 0;
                if (tx_Nome.Text.Equals(""))
                {
                    label_toolstrip.ForeColor = Color.Red;
                    label_toolstrip.Text = "Não Localizado!";
                    botao_inserir.Enabled = true;
                    botao_editar.Enabled = false;
                    status = false;
                }
                else
                {
                    label_toolstrip.Text = "Cadastrado!";
                    botao_inserir.Enabled = false;
                }
            }
            if (status == false)
            {
                Habilita_Campos();
                Preenche_Enderecos();
            }
            else
                botao_editar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (status)
            {
                MessageBox.Show("Usuário já cadastrado", "Atenção");
            }
            else
            {

            }
        }

        //Medoto que busca caso o botão de radio seja alterado
        private void radio_Antigo_CheckedChanged(object sender, EventArgs e)
        {
            tx_Prontuario_TextChanged(sender, e);
        }

        //Botao Editar e Salvar
        private void button3_Click(object sender, EventArgs e)
        {
            Preenche_Enderecos();
            //PreencheACS_Microarea();
            //Edita o usuario localizado
            if (botao_editar.Text.Equals("Salvar"))
            {
                
                if (radio_Novo.Checked == true)
                {
                    string[] aux = new string[12];
                    aux[0] = "N";
                    aux[1] = tx_Prontuario.Text;
                    aux[2] = tx_CartaoSus.Text;
                    aux[3] = tx_Nome.Text;
                    aux[4] = tx_Telefone.Text;
                    aux[5] = PreencheData(tx_data.Text);
                    aux[6] = cb_Enderecos.SelectedItem.ToString();
                    aux[7] = tx_Numero.Text;
                    aux[8] = tx_Complemento.Text;
                    aux[9] = tx_Bairro.Text;
                    aux[10] = tx_Microarea.Text;
                    aux[11] = tx_ACS.Text;
                    
                    Usuarios_Novo.Insert(Posicao_Novo, aux);
                    Usuarios_Novo.RemoveAt(Posicao_Novo + 1);
                    
                    Desabilita_Campos();
                    botao_sair.Enabled = true;
                    botao_editar.Text = "Editar";
                    MessageBox.Show("Salvo com sucesso!","Ok!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    tx_Prontuario.Text = "";
                    tx_Prontuario_TextChanged(sender, e);
                }
                


            }
                //else da condição se (linha 245)  do botao se está em editar ou salvar 
            else
            {
                status = false;
                button2_Click(sender, e);
                Habilita_Campos();
                botao_inserir.Enabled = false;
                botao_sair.Enabled = false;
                botao_editar.Text = "Salvar";
            }
        }

        private void Habilita_Campos()
        {
            tx_CartaoSus.ReadOnly = false;
            tx_Bairro.ReadOnly = false;
            tx_Nome.ReadOnly = false;
            tx_Telefone.ReadOnly = false;
            tx_Numero.ReadOnly = false;
            tx_Complemento.ReadOnly = false;
            cb_Enderecos.Enabled = true;
            tx_data.ReadOnly = false;
        }

        //Metodo para adicionar elementos na combobox endreço.
        private void Preenche_Enderecos()
        {
            string[] aux = Areas_Recebidas[0].Split(';');

            //Adiciona ruas na combobox
            cb_Enderecos.Items.Add(aux[1]);
            Ruas.Add(aux[1]);            
            
            for (int i = 1; i < Areas_Recebidas.Length; i++)
            {
                int count = 0;
                aux = Areas_Recebidas[i].Split(';');

                //remove os itens iguais
                for (int j = 0; j < cb_Enderecos.Items.Count; j++)
                {
                    if (aux[1].Equals(cb_Enderecos.Items[j]))
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    cb_Enderecos.Items.Add(aux[1]);
                }
            }
            //Ordena os enderecos
            cb_Enderecos.Sorted = true;
 
        }

        //Metodo para desabiliatr os textbox
        private void Desabilita_Campos()
        {
            tx_CartaoSus.ReadOnly = true;
            tx_Bairro.ReadOnly = true;
            tx_Nome.ReadOnly = true;
            tx_Telefone.ReadOnly = true;
            tx_Numero.ReadOnly = true;
            tx_Complemento.ReadOnly = true;
            //cb_Enderecos.ReadOnly = true;
            cb_Enderecos.Enabled = false;
            tx_data.ReadOnly = true;
            status = true;
 
        }

        private void Pesquisa_JaCadastrados()
        {
 
        }

        private string PreencheData(string data)
        {
            string auxdata = "";
            for (int i = 0; i < data.Length; i++)
            {
                auxdata += data[i];
                if (i == 1 || i == 3)
                {
                    auxdata += '/';
                }
            }

            return auxdata;
        }

        private string BuscaMicroarea()
        {
            string Micro_ACS = "";
            int auxNumero;
            for (int i = 0; i < Areas_Recebidas.Length; i++)
            {
                string[] Aux = Areas_Recebidas[i].Split(';');
                if (Aux[1].Equals(cb_Enderecos.SelectedItem.ToString()))
                {
                    if (tx_Numero.Text == "")
                    {
                        auxNumero = 0;
                    }
                    else
                        auxNumero = int.Parse(tx_Numero.Text);

                    if (Testa_NumeroRua(Aux,auxNumero) == 1)
                    {
                        Micro_ACS = Aux[0];
                    }
                }

            }
            if (Micro_ACS.Equals(""))
            {
                Micro_ACS = "0";
            }
            return Micro_ACS;
                         
        }

        private void PreencheACS_Microarea()
        {
            string Microarea = BuscaMicroarea();
            for (int i = 0; i < Agentes_Recebidos.Length; i++)
            {
                string[] aux = Agentes_Recebidos[i].Split(';');
                if (Microarea.Equals(aux[0]))
                {
                    tx_Microarea.Text = Microarea;
                    tx_ACS.Text = aux[1];
                    break;
                }
                else
                {
                    tx_Microarea.Text = "null";
                    tx_ACS.Text = "null";
                }
            } 
        }

        //Metodo que procura um intervalo dos numeros de cada rua
        private int Testa_NumeroRua(string [] Aux, int Numero)
        {
            ArrayList listaaux = new ArrayList();
            int status = 0;
            for (int i = 2; i < Aux.Length; i++)
            {
                if (Aux[i].Equals(""))
                    break;
                else
                {
                    listaaux.Add(int.Parse(Aux[i]));
                }
            }
            listaaux.Sort();
            if ((int)listaaux[0] <= Numero && (int)listaaux[listaaux.Count - 1] >= Numero)
            {
                status = 1;
            }

            return status;
 
        }

        private void tx_Numero_TextChanged(object sender, EventArgs e)
        {
            PreencheACS_Microarea();
        }

        private void cb_Enderecos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencheACS_Microarea();
        }

        
        
    }
}

