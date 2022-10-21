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
    public partial class Validate_Book : Form
    {
        public Validate_Book()
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
                    Bookshop bookshop = new Bookshop();
                    string code = BookCode_textBox1.Text.Trim();

                    if (bookshop.ValidateBook(code))
                    {
                        Clean_Fields();
                        MessageBox.Show("The Book Does Exist");
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
