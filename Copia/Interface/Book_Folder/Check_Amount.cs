using BookStoreApp.Model;
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
    public partial class Check_Amount : Form
    {
        public Check_Amount()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Send_button1_Click(object sender, EventArgs e)
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else
            {
                try
                {
                    string code = BookCode_textBox1.Text.Trim();
                    int amount = Main.bookshop.QuantityUnits(code);

                    if (amount != 0)
                    {
                        Clean_Fields();
                        MessageBox.Show($"The Number Of Books There Are {amount}");
                    }
                    else
                    {
                        Clean_Fields();
                        MessageBox.Show("The Book Does Not Exist");
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
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
