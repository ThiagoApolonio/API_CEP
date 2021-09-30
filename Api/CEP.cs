using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Api
{
    public partial class CEP : Form
    {
        public CEP()
        {
            InitializeComponent();
        }

        private void CEP_Leave(object sender, EventArgs e)
        {
                if (!String.IsNullOrEmpty(txtCEP.Text))
            {
                if (Regex.IsMatch(txtCEP.Text, @"^\d+$"))
                {
                    if (txtCEP.Text.Replace("-", "").Replace(".", "").TrimEnd().TrimStart().Length == 8)
                    {
                        CLcep.TexsBoxs texsBoxs = new CLcep.TexsBoxs();
                        texsBoxs = CLcep.GetApi(txtCEP.Text.Replace("-", "").Replace("-", "").TrimEnd().TrimStart());
                        txtLogradouro.Text = texsBoxs.logradouro;
                        txtComplemento.Text = texsBoxs.complemento;
                        txtBairro.Text = texsBoxs.bairro;
                        txtLocalidade.Text = texsBoxs.localidade;
                        txtUF.Text = texsBoxs.uf;
                        txtUnidade.Text = texsBoxs.unidade;
                        txtIBGE.Text = texsBoxs.ibge;
                        txtGIA.Text = texsBoxs.gia;


                    }
                    else
                    {
                        MessageBox.Show("Campo de CEP tem que ter 8 digitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Cep no formado inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Cep é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
           
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
