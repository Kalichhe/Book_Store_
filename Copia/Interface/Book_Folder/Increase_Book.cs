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
    public partial class Increase_Book : Form
    {
        public Increase_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Increase_button1_Click(object sender, EventArgs e)
        {
            if (BookCode_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else if (Amount_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A AMOUNT");
            }
            else
            {
                try
                {

                    string code = BookCode_textBox1.Text.Trim();
                    int amount = Convert.ToInt32(Amount_textBox1.Text.Trim());

                    if (Main.bookshop.ValidateBook(code))
                    {
                        Clean_Fields();
                        Main.bookshop.IncreaseUnits(code, amount);
                        MessageBox.Show("Increased Units");
                    }
                    else
                    {
                        Clean_Fields();
                        MessageBox.Show("Non Existing Book");
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
            Amount_textBox1.Text = "";
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
