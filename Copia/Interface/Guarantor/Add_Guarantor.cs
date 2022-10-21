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
    public partial class Add_Guarantor : Form
    {
        public Add_Guarantor()
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
            if (IdentificationCard_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A CODE");
            }
            else if (Name_textBox1.Text.Trim().Length < 4)
            {
                MessageBox.Show("ENTER A LONGER NAME");
            }
            else if (Payment_textBox1.Text.Trim() == "")
            {
                MessageBox.Show("ENTER A PAYMENT");
            }
            else
            {
                try
                {

                    int code = Convert.ToInt32(IdentificationCard_textBox1.Text.Trim());
                    string name = Name_textBox1.Text.Trim();
                    double payment = Convert.ToDouble(Payment_textBox1.Text.Trim());
                    double totalPayment = Main.bookshop.cart.CalculateTotal();
                    double debt = totalPayment - payment;

                    if (Main.bookshop.CheckBondsman(code))
                    {
                        Clean_Fields();
                        Main.bookshop.AddDebt(code, debt);
                        MessageBox.Show("Debt Increased Correctly");
                    }
                    else
                    {
                        Clean_Fields();
                        Main.bookshop.AddBondsman(code, name, debt);
                        MessageBox.Show("Guarantor Properly Created With Debt");
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
            IdentificationCard_textBox1.Text = "";
            Name_textBox1.Text = "";
            Payment_textBox1.Text = "";
        }
    }
}
