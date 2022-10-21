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
    public partial class Book_Form : Form
    {
        public Book_Form()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void AddBook_button3_Click(object sender, EventArgs e)
        {
            using (Add_Book add_Book = new Add_Book())
                add_Book.ShowDialog();
        }

        private void ModifyBook_button4_Click(object sender, EventArgs e)
        {
            using (Modify_Book modify_Book = new Modify_Book())
                modify_Book.ShowDialog();
        }

        private void ToClose_button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteBook_button3_Click(object sender, EventArgs e)
        {
            using (Delete_Book delete_Book = new Delete_Book())
                delete_Book.ShowDialog();
        }

        private void ValidateBook_button3_Click(object sender, EventArgs e)
        {
            using (Validate_Book validate_Book = new Validate_Book())
                validate_Book.ShowDialog();
        }
    }
}
