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
    public partial class Add_Book : Form
    {
        public Add_Book()
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
            else if (BookName_textBox1.Text.Trim().Length < 4)
            {
                MessageBox.Show("ENTER A LONGER NAME");
            }
            else if (BookCategory_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CATEGORY");
            }
            else if (BookAmount_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A AMOUNT");
            }
            else if (BookValue_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A VALUE");
            }
            else
            {
                try
                {
                    Bookshop bookshop = new Bookshop();
                    string code = BookCode_textBox1.Text.Trim();
                    string name = BookName_textBox1.Text.Trim();
                    string category = BookCategory_textBox1.Text.Trim();
                    int amount = Convert.ToInt32(BookAmount_textBox1.Text.Trim());
                    double value = Convert.ToDouble(BookValue_textBox1.Text.Trim());

                    if (bookshop.AddBook(code, name, category, amount, value))
                    {
                        Clean_Fields();
                        MessageBox.Show("Added Book");
                    }
                    else
                    {
                        Clean_Fields();
                        MessageBox.Show("This Book Already Exists");
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
            BookName_textBox1.Text = "";
            BookCategory_textBox1.Text = "";
            BookAmount_textBox1.Text = "";
            BookValue_textBox1.Text = "";
        }
    }
}
