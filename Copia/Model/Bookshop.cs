using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace BookStoreApp.Model
{
    public class Bookshop
    {
        public List<Book> Books { get; set; }
        public List<Fiador> Fiadores { get; set; }
        public Cart cart { get; set; }
        
        public Bookshop()
        {
            Books = new List<Book>();

            cart = new Cart();

            Fiadores = new List<Fiador>();

            Book libro1 = new Book("1", "GOT", "Ficción", 20, 5000);

            Book libro2 = new Book("2","House of the dragon", "Ficción", 20, 5000);
           

            Books.Add(libro1);
            Books.Add(libro2);
        }

        //Validamos si la libria cuenta con el libro.
        /// <summary>
        /// Verifica que el libro está en la biblioteca (se busca el libro usando el código como parámetro)
        /// RF 04 - HU 04
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Si el libro está en la biblioteca, devolvemos true, de lo contrario, false.</returns>
        public bool ValidateBook(string code)
        {

            foreach (Book book in Books)
            {
                if (book.Code == code){
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Le permite cambiar el nombre, la categoría y el valor del libro. (el libro se busca por código)
        /// RF 02 - HU 02
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        /// <param name="value"></param>
        /// <returns>Si se encuentra el libro, se cambian sus atributos a modificar y devolvemos verdadero, en caso contrario devolvemos falso.</returns>
        public bool ModifyBook(string code, string name, string category, int amount, double value)
        {
            foreach (Book book in Books)
            {
                if (book.Code == code)
                {
                    book.Name = name;
                    book.Category = category;
                    book.Amount = amount;
                    book.Value = value;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Le permite agregar un nuevo libro a la biblioteca 
        /// RF 01 - HU 01
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        /// <param name="value"></param>
        /// <returns>Si el libro no existe: se añade a la biblioteca y devolvemos verdadero.
        ///Si el libro existe en la biblioteca: no se agrega a la biblioteca y devolvemos falso</returns>
        public bool AddBook(string code, string name, string category, int amount, double value)
        {
            if (ValidateBook(code))
            {
                return false;
            }
            else
            {
                Book book = new Book(code, name, category, amount, value);
                Books.Add(book);
                return true; 
            }

        }

        /// <summary>
        /// Se elimina un libro de la lista de libros (se busca el libro mediante el código)
        /// RF 03 - HU 03
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Retorna True si el libro es eliminado, de lo contrario retorna False</returns>
        public bool DeleteBook(string code)
        {
            foreach  (Book book in Books)
            {
                if (book.Code == code)
                {
                    Books.Remove(book);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Muestra en la interfaz los libros en una lista, con el código, nombre, categoría, unidades y valor.
        /// FR 08 - HU 08
        /// </summary>
        /// <returns>Devuelve una cadena con los libros que existen en la biblioteca.</returns>
        public string ListBooks()
        {
            string lista = "";
            foreach (Book item in Books)
            {
                lista += " Code: " + item.Code + " " + "Name: " + item.Name + " " + "Category: " + item.Category + " " + "Amount: " + item.Amount + " " + "Value: " + item.Value + "\r\n";
            }
            return lista;
        }

        /// <summary>
        /// Se añade un libro al carrito de la compra.
        /// RF 05 - HU 05
        /// </summary>
        /// <param name="code"></param>
        /// <param name="amount"></param>
        /// <returns>Si el valor del libro es igual a 0, el libro no se agrega al carrito y se devuelve falso, en caso contrario se agrega el libro y se devuelve verdadero.</returns>
        public bool AddBooksToCart(string code, int amount)
        {
            if (ValidateBook(code))
            {
                double price = buscarPrecio(code);
                if (price == 0)
                {
                    return false;
                }
                else
                {
                    (int, double) t = (amount, price);
                    cart.Book.Add(code, t);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The books in the cart are sold and the units sold are subtracted.
        /// </summary>
        public void SellBooks()
        {
            foreach (KeyValuePair<string, (int, double)> book in cart.Book)
            {
                SubtractUnits(book.Key, book.Value.Item1);
            }
            cart = new Cart();

        }

        /// <summary>
        /// Allows you to add a guarantor to the system (if a client cannot pay the total, they can be added as a guarantor).
        /// </summary>
        /// <param name="id">DNI</param>
        /// <param name="name"></param>
        /// <param name="debt">deuda</param>
        public void AddBondsman(int id, string name, double debt = 0) //agregar fiador.
        {
            Fiador bondsman = new Fiador(id, name, debt);
            Fiadores.Add(bondsman);
        }

        /// <summary>
        /// Se verifica si el fiador está en el sistema.
        /// RF 13 - HU 13
        /// </summary>
        /// <param name="id">DNI</param>
        /// <returns>Si el garante está en el sistema, se devuelve verdadero, de lo contrario, se devuelve falso.</returns>
        public bool CheckBondsman(int id) //Verificar fiador
        {
            foreach (Fiador bondsman in Fiadores)
            {
                if (bondsman.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Pay off a bondsman's debt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns>The value provided by the guarantor is subtracted and true is returned, if the id is not found, false is returned.</returns>
        public bool PayDebt(int id, double value) //pagar deuda.
        {
            if (CheckBondsman(id))
            {
                foreach (Fiador bondsman in Fiadores)
                {
                    if (bondsman.Id == id)
                    {
                        bondsman.Debt -= value;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Save the fasteners in a list of strings
        /// </summary>
        /// <returns>A list of strings with the guarantors is returned.</returns>
        public string ListBondsman()//Listar fiadores.
        {
            string lista = "";
            foreach (Fiador item in Fiadores)
            {
                lista += "DNI: " + item.Id + " " + "NAME: "+ item.Name + " " + "DEBT: " +  item.Debt + "\r\n";
            }
            return lista;
        }

        public double buscarPrecio(string codigo)
        {
            double valor = 0;

            foreach (Book libro in Books)
            {
                if (libro.Code == codigo)
                {
                    return libro.Value;
                }
            }
            return valor;
        }

        public void SubtractUnits(string code, int numUnits) //Restar unidades de un libro.
        {
            foreach (Book book in Books)
            {
                if (book.Code == code)
                {
                    book.SubtractBook(numUnits);
                }
            }
        }
        public void IncreaseUnits(string code, int numUnits) //Aumentar unidades de un libro.
        {
            foreach (Book book in Books)
            {
                if (book.Code == code)
                {
                    book.AddAmount(numUnits);
                }
            }
        }

        /// <summary>
        /// Comprobar el número de unidades en un libro.
        /// RF 17 - HU 17
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Se devuelve el número de unidades del libro.</returns>
        public int QuantityUnits(string code) //cantidad de unidades.
        {
            foreach (Book book in Books)
            {
                if (book.Code == code)
                {
                    return book.Amount;
                }
            }
            return 0;
        }

        /// <summary>
        /// Increases the debt of a guarantor if he wishes.
        /// </summary>
        /// <param name="id">DNI</param>
        /// <param name="debt">Deuda</param>
        public void AddDebt(int id,double debt) //sumar deuda.
        {
            foreach (Fiador item in Fiadores)
            {
                if (item.Id == id)
                {
                    item.Debt += debt;
                }
            }
        }

        /// <summary>
        /// Search for the debt of a guarantor (the guarantor is searched for by the id/cedula).
        /// </summary>
        /// <param name="id">DNI</param>
        /// <returns>Return -1 if the debt is not found, otherwise return the debt.</returns>
        public double SearchDebt(int id) //Buscar deuda
        {
            foreach (Fiador item in Fiadores)
            {
                if (item.Id == id)
                {
                    return item.Debt;
                }
            }
            return -1;
        }

        /// <summary>
        /// Show a list of all the books which have in the inventory a smaller quantity as indicated by the bookstore showing the code of the book and the number of units.
        /// </summary>
        /// <returns>Returns a string in the form of a list with the books about to run out.</returns>
        public string UnitsToRunOut() //Unidades por agotar
         {
            string list = "";
            foreach (Book item in Books)
            {
                if (item.Amount < 5)
                {
                    list += " Code: " + item.Code + " " + "Name: " + item.Name + " " + "Category: " + item.Category + " " + "Amount: " + item.Amount + " " + "Value: " + item.Value + "\r\n";
                }
            }
            return list;

        }
    }
}
