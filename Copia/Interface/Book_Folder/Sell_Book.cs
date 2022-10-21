using Copia.Interface.Guarantor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copia.Interface.Book_Folder
{
    public partial class Sell_Book : Form
    {
        public Sell_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateTotal_button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(Main.bookshop.cart.CalculateTotal());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sell_button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("First Calculate Total");
            }
            else
            {
                Main.bookshop.SellBooks();
                MessageBox.Show("Books Sold");
                textBox1.Text = "";
            }
        }

        private void Legit_button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("First Calculate Total");
            }
            else
            {
                using (Add_Guarantor add_Guarantor = new Add_Guarantor())
                    add_Guarantor.ShowDialog();
            }
            


        }
    }
}
