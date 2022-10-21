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
    public partial class Units_Nearing_Depletion : Form
    {
        public Units_Nearing_Depletion()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToList_button1_Click(object sender, EventArgs e)
        {
            string list = Main.bookshop.UnitsToRunOut();
            textBox1.Text = list;
        }
    }
}
