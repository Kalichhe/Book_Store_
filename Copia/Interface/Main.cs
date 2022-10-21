using BookStoreApp.Model;
using Copia.Interface.Book_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Copia.Interface.Book_Folder;

namespace Copia.Interface
{
    public partial class Main : Form
    {
        public static Bookshop bookshop;

        public Main()
        {
            InitializeComponent();
            bookshop = new Bookshop();
            CenterToScreen();
        }

        private void Book_button1_Click(object sender, EventArgs e)
        {

        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ShowBook_button2_Click(object sender, EventArgs e)
        {

        }

        private void Guarantor_button2_Click(object sender, EventArgs e)
        {

        }

        private void Book_button1_Click_1(object sender, EventArgs e)
        {
            Book_Form book_Form = new Book_Form();
                book_Form.ShowDialog();
            
        }

        private void ShowBook_button2_Click_1(object sender, EventArgs e)
        {
            using (Show_Book show_Book = new Show_Book())
                show_Book.ShowDialog();
        }

        private void Guarantor_button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
