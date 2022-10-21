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
    public partial class Decrease_Book : Form
    {
        public Decrease_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Decrease_button1_Click(object sender, EventArgs e)
        {
            {
                if (Code_textBox1.Text.Trim() == "")
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

                        string code = Code_textBox1.Text.Trim();
                        int amount = Convert.ToInt32(Amount_textBox1.Text.Trim());

                        if (Main.bookshop.ValidateBook(code))
                        {
                            Clean_Fields();
                            Main.bookshop.SubtractUnits(code, amount);
                            MessageBox.Show("Decreased Units");
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
        }
        private void Clean_Fields()
        {
            Code_textBox1.Text = "";
            Amount_textBox1.Text = "";
        }
        
    }
}
