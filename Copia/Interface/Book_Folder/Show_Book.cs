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
    public partial class Show_Book : Form
    {
        public Show_Book()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Listar_button1_Click(object sender, EventArgs e)
        {
            Bookshop bookshop = new Bookshop();
            string list = bookshop.ListBooks();
            textBox1.Text = list;

        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
