using Copia.Interface.Guarantor;
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

        private void CheckAmount_button3_Click(object sender, EventArgs e)
        {
            using (Check_Amount check_Amount = new Check_Amount())
                check_Amount.ShowDialog();
        }

        private void UnitsNearingDepletion_button3_Click(object sender, EventArgs e)
        {
            using (Units_Nearing_Depletion units_Nearing_Depletion = new Units_Nearing_Depletion())
                units_Nearing_Depletion.ShowDialog();
        }

        private void AddBookToCart_button1_Click(object sender, EventArgs e)
        {
            using (Add_To_Cart add_To_Cart = new Add_To_Cart())
                add_To_Cart.ShowDialog();
        }

        private void SellBook_button3_Click(object sender, EventArgs e)
        {
            using (Sell_Book sell_Book = new Sell_Book())
                sell_Book.ShowDialog();
        }

        private void ShowGuarantor_button1_Click(object sender, EventArgs e)
        {
            using (Show_Guarantor show_Guarantor = new Show_Guarantor())
                show_Guarantor.ShowDialog();
        }

        private void PayDebt_button1_Click(object sender, EventArgs e)
        {
            using (Pay_Debt pay_Debt = new Pay_Debt())
                pay_Debt.ShowDialog();
        }

        private void IncreaseBook_button1_Click(object sender, EventArgs e)
        {
            using (Increase_Book increase_Book = new Increase_Book())
                increase_Book.ShowDialog();
        }

        private void DecreaseBook_button2_Click(object sender, EventArgs e)
        {
            using (Decrease_Book decrease_Book = new Decrease_Book())
                decrease_Book.ShowDialog();
        }
    }
    
}
