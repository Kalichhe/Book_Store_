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
    public partial class Add_To_Cart : Form
    {
        public Add_To_Cart()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Send_button1_Click(object sender, EventArgs e)
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else if (Units_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A AMOUNT");
            }
            else
            {
                try
                {
                    string code = BookCode_textBox1.Text.Trim();
                    int amount = Convert.ToInt32(Units_textBox1.Text.Trim());

                    if (Main.bookshop.AddBooksToCart(code, amount))
                    {
                        Clean_Fields();
                        MessageBox.Show("Book Added To Cart");
                    }
                    else
                    {
                        Clean_Fields();
                        MessageBox.Show("Error Adding Book");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Clean_Fields()
        {
            BookCode_textBox1.Text = "";
            Units_textBox1.Text = "";
        }
    }
}
