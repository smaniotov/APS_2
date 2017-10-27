using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace APS_Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAPSDataSet.tbDocument' table. You can move, or remove it, as needed.
            this.tbDocumentTableAdapter.Fill(this.dbAPSDataSet.tbDocument);
            txtNome.Enabled = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            txtDecriptar.Enabled = false;
            txtBox.Enabled = false;
            cbmDoc.Text = "";
        }
        public int modo;
    

        public void HabText()
        {
            //txtDecriptar.Enabled = true;
            txtBoxEncriptar.Enabled = true;
            txtBox.Enabled = true;
        }
        public void DesabText()
        {
            txtDecriptar.Enabled = false;
            txtBoxEncriptar.Enabled = false;
            txtBox.Enabled = false;
            txtNome.Enabled = false;
        }
        public void Criptografar()
        {
            //limpar a box de decrypt
            txtDecriptar.Text = string.Empty;

            //Intera todas as letra do texto puro
            for (int i = 0; i < txtBoxEncriptar.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = (int)txtBoxEncriptar.Text[i];

                //Coloca a chave fixa de 3 posições a mais no número da tabela ASCII
                int ASCIIC = ASCII+3;;

                //Concatena o texto na caixa de texto do texto crifrado
                txtDecriptar.Text += Char.ConvertFromUtf32(ASCIIC);
                
            }
        }
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if(modo == 0)
            {
                txtBox.Text = "";
            }
            if (modo == 2)
            {
                Criptografar();
                txtBox.Enabled = false;
                btnExcluir.Enabled = false;
                btn_Decrypt.Enabled = false;
                btnNovo.Enabled = false;
                txtDecriptar.Enabled = false;
                txtBoxEncriptar.Focus();
                btnConfirmar.Enabled = true;
                txtNome.Enabled = true;
               
            }
            else
            {
                Criptografar();
                HabText();
                txtBox.Enabled = false;
                txtDecriptar.Enabled = false;
            }
            
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //Limpa a caixa de texto
            txtBox.Text = string.Empty;

            //Intera todas as letras do texto cifrado
            for (int i = 0; i < txtDecriptar.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = (int)txtDecriptar.Text[i];

                //Coloca a chave fixa de 3 posições a menos no número da tabela ASCII
                int ASCIIC = ASCII -3;

                //Concatena o texto na caixa de texto do texto decifrado
                txtBox.Text += Char.ConvertFromUtf32(ASCIIC);
                HabText();
                txtBox.Enabled = false;
                btn_Encrypt.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-AU8BDDS;Initial Catalog=dbAPS;Integrated Security=True");
            conexao.Open();
            SqlCommand cmd = new SqlCommand("Select *  from tbDocument where DocNome='" + cbmDoc.Text + "'", conexao);

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dtRetorno = new DataTable();
            if (dr.Read())
            {

                txtNome.Text = dr.GetSqlValue(0).ToString();
                txtDecriptar.Text = dr.GetSqlValue(1).ToString();
                
            }
            dr.Close();
             
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDecriptar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEncriptar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            LimpCampos();
            txtNome.Focus();
            btnAcessar.Enabled = false;
            MessageBox.Show("Para cadastrar um documento encriptografe seu conteúdo", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBox.Enabled = false;
            btnExcluir.Enabled = false;
            btn_Decrypt.Enabled = false;
            btnNovo.Enabled = false;
            txtDecriptar.Enabled = false;
            btnConfirmar.Enabled = true;
            txtNome.Enabled = true;
            modo = 2;
            
        }
        public void ExcluiDoc()
        {
            try
            {
                if (txtNome.Text == "" || txtDecriptar.Text == "")
                {
                    MessageBox.Show("Escolha o documento a excluído", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDecriptar.Enabled = false;
                }

                else
                {
                    SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-AU8BDDS;Initial Catalog=dbAPS;Integrated Security=True");
                    conexao.Open();
                    SqlCommand cmd = new SqlCommand("delete from tbDocument where DocNome='" + txtNome.Text + "'", conexao);

                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    cbmDoc.Refresh();
                    this.tbDocumentTableAdapter.Fill(this.dbAPSDataSet.tbDocument);
                    MessageBox.Show("Excluído com Sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpCampos();
                }
            }
            catch
            {
                MessageBox.Show("Não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CadastrarDoc()
        {
            try
            {
                if (txtNome.Text == "" || txtDecriptar.Text == "")
                {
                    MessageBox.Show("Digite o nome do novo documento e criptografe a mensagem a ser gravada!", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtDecriptar.Enabled = false;
                }

                else
                {
                    SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-AU8BDDS;Initial Catalog=dbAPS;Integrated Security=True");
                    conexao.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbDocument (DocNome, Conteudo) values ('" + txtNome.Text + "','" + txtDecriptar.Text + "')", conexao);

                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    cbmDoc.Refresh();
                    this.tbDocumentTableAdapter.Fill(this.dbAPSDataSet.tbDocument);
                    MessageBox.Show("Cadastrado com Sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpCampos();                   
                }
            }
            catch
            {
                MessageBox.Show("Já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimpCampos()
        {
            txtBox.Clear();
            txtDecriptar.Clear();
            txtBoxEncriptar.Clear();
            txtNome.Clear();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == 2)
            {
                CadastrarDoc();
                modo = 0;
                btnAcessar.Enabled = true;
                txtBox.Enabled = false;
                btnExcluir.Enabled = true;
                btn_Decrypt.Enabled = true;
                btnNovo.Enabled = true;
                txtBoxEncriptar.Focus();
                btnConfirmar.Enabled = false;
                txtNome.Enabled = false;
                btn_Encrypt.Enabled = true;
                btnCancelar.Enabled = false;
            }
            else
            {
                if(modo==3)
                {
                    ExcluiDoc();
                    modo = 0;
                    btnAcessar.Enabled = true;
                    txtBox.Enabled = false;
                    btnExcluir.Enabled = true;
                    btn_Decrypt.Enabled = true;
                    btnNovo.Enabled = true;
                    txtBoxEncriptar.Focus();
                    btnConfirmar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtNome.Enabled = false;
                    btn_Encrypt.Enabled = true;
                }
            }
        }

        private void cbmDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbDocumentTableAdapter.FillBy(this.dbAPSDataSet.tbDocument);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpCampos();
            btnAcessar.Enabled = true;
            txtBox.Enabled = false;
            txtBoxEncriptar.Enabled = true;
            btnExcluir.Enabled = true;
            btn_Decrypt.Enabled = true;
            btn_Encrypt.Enabled = true;
            btnNovo.Enabled = true;
            txtBoxEncriptar.Focus();
            btnConfirmar.Enabled = false;
            txtNome.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            modo = 3;
            DesabText();
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btn_Decrypt.Enabled = false;
            btn_Encrypt.Enabled = false;

        }
        public void Desab()
        {
            btnNovo.Enabled = false;
            btn_Decrypt.Enabled = false;
            btn_Encrypt.Enabled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            txtDecriptar.Text = "";
            txtBoxEncriptar.Text = "";
            cbmDoc.Text = "";
            txtNome.Text = "";
        }

    }
}
 