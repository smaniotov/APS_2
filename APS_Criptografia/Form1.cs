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
            textBox1.Enabled = false;
            textBox1.Text = "Atenção, todas as informações aqui contidas são confidencias e para uso exclusivo de pesquisadores, inspetores e orgãos governamentais. Caso não consiga acessar a informação desejada por favor contatar o administrador.";
        }
        
        public void DesabText()
        { txtBoxDecriptar.Enabled = false;
            txtBoxEncriptar.Enabled = false;
            txtBox.Enabled = false;
        }

        public void HabText()
        {
            txtBoxDecriptar.Enabled = true;
            txtBoxEncriptar.Enabled = true;
            txtBox.Enabled = true;
        }
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            HabText();
            
            //limpar a box de decrypt
            txtBoxDecriptar.Text = string.Empty;
 
            //Intera todas as letra do texto puro
            for (int i = 0; i < txtBoxEncriptar.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = (int)txtBoxEncriptar.Text[i];

                //Coloca a chave fixa de 10 posições a mais no número da tabela ASCII
                int ASCIIC = ASCII + 10;

                //Concatena o texto na caixa de texto do texto crifrado
                txtBoxDecriptar.Text += Char.ConvertFromUtf32(ASCIIC);
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //Limpa a caixa de texto
            txtBox.Text = string.Empty;

            //Intera todas as letras do texto cifrado
            for (int i = 0; i < txtBoxDecriptar.Text.Length; i++)
            {

                //Devolve o código ASCII da letra
                int ASCII = (int)txtBoxDecriptar.Text[i];

                //Coloca a chave fixa de 10 posições a menos no número da tabela ASCII
                int ASCIIC = ASCII - 10;

                //Concatena o texto na caixa de texto do texto decifrado
                txtBox.Text += Char.ConvertFromUtf32(ASCIIC);
                HabText();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
 