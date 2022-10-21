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
    public partial class Modify_Book : Form
    {
        public Modify_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        
        private void Send_button1_Click(object sender, EventArgs e)
            {
                if (Code_textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("ENTER A CODE");
                }
                else if (NewBookName_textBox1.Text.Trim().Length < 4)
                {
                    MessageBox.Show("ENTER A LONGER NAME");
                }
                else if (NewBookCategory_textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("ENTER A CATEGORY");
                }
                else if (NewBookAmount_textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("ENTER A AMOUNT");
                }
                else if (NewBookValue_textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("ENTER A VALUE");
                }
                else
                {
                    try
                    {
                        Bookshop bookshop = new Bookshop();
                        string code = Code_textBox1.Text.Trim();
                        string name = NewBookName_textBox1.Text.Trim();
                        string category = NewBookCategory_textBox1.Text.Trim();
                        int amount = Convert.ToInt32(NewBookAmount_textBox1.Text.Trim());
                        double value = Convert.ToDouble(NewBookValue_textBox1.Text.Trim());
    
                        if (bookshop.ModifyBook(code, name, category, amount, value))
                        {
                            Clean_Fields();
                            MessageBox.Show("The Book Has Been Modified");
                        }
                        else
                        {
                            Clean_Fields();
                            MessageBox.Show("Book Not Found");
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
            Code_textBox1.Text = "";
            NewBookName_textBox1.Text = "";
            NewBookCategory_textBox1.Text = "";
            NewBookAmount_textBox1.Text = "";
            NewBookValue_textBox1.Text = "";
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
