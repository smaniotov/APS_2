using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_Criptografia
{
    public partial class frmUsu : Form
    {
        public frmUsu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" || txtSenhaMestra.Text == ""||txtNovaSenha.Text=="")
                {
                    MessageBox.Show("Preencha todos os campos!", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }

                else
                {
                    if (txtSenhaMestra.Text == "12345678")
                    {
                        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-AU8BDDS;Initial Catalog=dbAPS;Integrated Security=True");
                        conexao.Open();
                        SqlCommand cmd = new SqlCommand("insert into tbLogin (LoginUsu, LoginSenha) values ('" + txtNome.Text + "','" + txtNovaSenha.Text + "')", conexao);

                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        MessageBox.Show("Cadastrado com Sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLogin frm = new frmLogin();
                        this.Hide();
                        frm.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Usuário já cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNovaSenha.Text = "";
                txtSenhaMestra.Text = "";

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void frmUsu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
