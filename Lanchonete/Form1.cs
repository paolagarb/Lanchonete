using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class Form1 : Form
    {
        string[] codigo = new string[5] { "001", "002", "003", "004", "005" };
        string[] nome = new string[5] { "SALGADO", "SUCO NATURAL", "REFRIGERANTE", "TORTA DOCE", "PASTEL" };
        double[] preco = new double[5] { 4.50, 3.50, 4.00, 5.00, 4.50 };

        double total = 0.00;


        public Form1()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void pctCardapio_Click(object sender, EventArgs e)
        {
            pnlCardapio.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pnlCardapio.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            List<Item> cardapio = new List<Item>();
            for (int i = 0; i <= 4; i++)
            {
                cardapio.Add(new Item(codigo[i], nome[i], preco[i]));
            }

            if (txtProduto.Text.Length == 3)
            {
                if (txtProduto.Text == "001")
                {
                    lstProdutos.Items.Add(cardapio[0]);
                    Adicionado();
                    total += 4.50;
                    picFotos.ImageLocation = "C:/Users/paola/OneDrive/Área de Trabalho/C-Sharp W.Forms/Lanchonete/Fotos/Salgado.jpg";
                }
                else if (txtProduto.Text == "002")
                {
                    lstProdutos.Items.Add(cardapio[1]);
                    Adicionado();
                    total += 3.50;
                    picFotos.ImageLocation = "C:/Users/paola/OneDrive/Área de Trabalho/C-Sharp W.Forms/Lanchonete/Fotos/Suco_natural.jpg";
                }
                else if (txtProduto.Text == "003")
                {
                    lstProdutos.Items.Add(cardapio[2]);
                    Adicionado();
                    total += 4.00;
                    picFotos.ImageLocation = "C:/Users/paola/OneDrive/Área de Trabalho/C-Sharp W.Forms/Lanchonete/Fotos/refrigerante.jpg";
                }
                else if (txtProduto.Text == "004")
                {
                    lstProdutos.Items.Add(cardapio[3]);
                    Adicionado();
                    total += 5.00;
                    picFotos.ImageLocation = "C:/Users/paola/OneDrive/Área de Trabalho/C-Sharp W.Forms/Lanchonete/Fotos/Torta_doce.jpg";
                }
                else if (txtProduto.Text == "005")
                {
                    lstProdutos.Items.Add(cardapio[4]);
                    Adicionado();
                    total += 4.50;
                    picFotos.ImageLocation = "C:/Users/paola/OneDrive/Área de Trabalho/C-Sharp W.Forms/Lanchonete/Fotos/Pastel.jpg";
                }
                else
                {
                    MessageBox.Show("Código inválido. Verifique o cardápio.", "Inválido");
                }
            }
            else if (txtProduto.Text.Length > 3)
            {
                MessageBox.Show("Código inválido. Verifique o cardápio.", "Inválido");
            }
            lblTotal.Visible = true;
            lblTotal.Text = "R$ " + total.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Adicionado()
        {
            txtProduto.Text = "";
            txtProduto.Focus();
        }
    }
}
