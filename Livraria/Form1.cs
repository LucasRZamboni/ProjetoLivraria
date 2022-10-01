using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nomeLivro.Text))
            {
                
                button3.Visible = false;
                
                MessageBox.Show("Nome do livro não preenchido!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nomeLivro.Focus();
            }
            else
            {
                button3.Visible = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_nomeLivro.Text = string.Empty;
            tb_qtdVendida.Text = string.Empty;
            tb_valorPagar.Text = string.Empty;
            cB_categoria.Text = string.Empty;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_nomeLivro.Text))
            {
                MessageBox.Show("Nome do livro não preenchido!!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float valorPagar, qtdVendida;
                if (cB_categoria.Text == "Aventura" || cB_categoria.Text == "Romance")
                {
                    qtdVendida = int.Parse(tb_qtdVendida.Text);
                    valorPagar = 20 * qtdVendida;
                    tb_valorPagar.Text = valorPagar.ToString("C");
                }
                else
                {
                    qtdVendida = int.Parse(tb_qtdVendida.Text);
                    valorPagar = 30 * qtdVendida;

                    tb_valorPagar.Text = valorPagar.ToString("C");
                }
            }
                
        }

        private void cB_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_categoria.Text == "Aventura" || cB_categoria.Text == "Romance")
            {
                MessageBox.Show("Categoria em promoção!! R$ 20,00", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preço normal!! R$ 30,00", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
