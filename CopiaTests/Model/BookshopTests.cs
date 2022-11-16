using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Model.Tests
{
    [TestClass()]
    public class BookshopTests
    {
        [TestMethod()]
        public void LibroExistenteTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.ValidateBook("1");

            //Assert
            Assert.IsTrue(resultado);

        }

        [TestMethod()]
        public void LibroNoExistenteFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.ValidateBook("0003");

            //Assert
            Assert.AreEqual(resultado, false);
        }

        [TestMethod()]
        public void LibroModificadoTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.ModifyBook("1", "CleanCode", "Programación", 50, 500);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void LibroNoModificadoFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.ModifyBook("0003", "CleanCode", "Programación", 50, 500);

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void AgregarLibroTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.AddBook("4", "CleanCode", "Programación", 50, 500);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void AgregarLibroFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.AddBook("2", "CleanCode", "Programación", 50, 500);

            //Assert
            Assert.IsTrue(!resultado);
        }

        [TestMethod()]
        public void EliminarLibroTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.DeleteBook("1");

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void EliminarLibroFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.DeleteBook("0003");

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void ListarLibros()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            string resultado = bookshop.ListBooks();

            //Assert
            Assert.IsNotNull(resultado);
        }

        [TestMethod()]
        public void AgregarLibroAlCarritoTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.AddBooksToCart("1", 5);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void AgregarLibroAlCarritoFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.AddBooksToCart("0", 5);

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void VerificarFiadorFalse()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bool resultado = bookshop.CheckBondsman(1);

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void VerificarFiadorTrue()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            bookshop.AddBondsman(100, "Chucho", 5000);
            bool resultado = bookshop.CheckBondsman(100);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void QuantityUnitsTest()
        {
            //Arrange
            Bookshop bookshop = new Bookshop();

            //Act
            int resultado = bookshop.QuantityUnits("1");

            //Assert
            Assert.AreEqual(resultado, 20);
        }
    }
}