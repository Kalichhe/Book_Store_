using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copia.Interface.Guarantor
{
    public partial class Pay_Debt : Form
    {
        public Pay_Debt()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void GoBack_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Search_button1_Click(object sender, EventArgs e)
        {
            if (DNI_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A DNI");
            }else if(Pay_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A PAY");
            }
            else
            {
                try
                {
                    int code = Convert.ToInt32(DNI_textBox1.Text.Trim());
                    double pay = Convert.ToDouble(Pay_textBox1.Text.Trim());

                    if (Main.bookshop.SearchDebt(code) == -1)
                    {
                        Clean_Fields();
                        MessageBox.Show("The Guarantor Does Not Exist");
                    }
                    else
                    {
                        Main.bookshop.PayDebt(code, pay);
                        MessageBox.Show("Payment Successfull");
                        Clean_Fields();
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
            DNI_textBox1.Text = "";
            Pay_textBox1.Text = "";

        }

    }
}
