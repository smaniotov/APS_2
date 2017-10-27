using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APS_Criptografia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text==""||txtUsu.Text=="")
            {
                MessageBox.Show("Preencha todos os campos!","Erro ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtUsu.Text = "";
                txtUsu.Focus();
            }
            else
            {
                SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-AU8BDDS;Initial Catalog=dbAPS;Integrated Security=True");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("Select *  from tbLogin where LoginUsu='" + txtUsu.Text + "' and LoginSenha = '" + txtSenha.Text + "'", conexao);
                
                SqlDataReader dr = cmd.ExecuteReader();

                    if(dr.Read())
                        {
                            MessageBox.Show("Logado", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 frm = new Form1();
                            this.Hide();
                            frm.Show();
                          //  CurrentUser user = new CurrentUser(2);
                            
                                                   }
                    else
                        {
                            MessageBox.Show("Usuário não encontrado","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSenha.Text = "";
                            txtUsu.Text = "";
                            txtUsu.Focus();
                        }

            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsu frm = new frmUsu();
            this.Hide();
            frm.Show();
        }
    }
}
