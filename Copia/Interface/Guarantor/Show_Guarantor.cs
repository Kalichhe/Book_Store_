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
    public partial class Show_Guarantor : Form
    {
        public Show_Guarantor()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowGuarantor_button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =  Main.bookshop.ListBondsman();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
