using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
   public class AddBorrowReturnDisplayBook
    {
        List<Book> BookList = new List<Book>();
        public void BookAddition()
        {
            var book = new Book();
            Console.WriteLine("Book Code:");
            book.BookCode = (Console.ReadLine());
            Console.WriteLine("Book Name:");
            book.name = (Console.ReadLine());
            Console.WriteLine("Book Author:");
            book.author = (Console.ReadLine());
            Console.WriteLine("Add Stock:");
            book.x = int.Parse(Console.ReadLine());
            BookList.Add(book);
            Console.WriteLine(BookList.Count);
        }
        public void BookBorrow()
        {
            var borrowBooks = new BorrowBook();
            Console.WriteLine("Book Code:");
            borrowBooks.BookCode = (Console.ReadLine());
            Console.WriteLine("Borrow Book Quantity:");
            borrowBooks.BorrowBookQuantity =int.Parse(Console.ReadLine());
            List<BorrowBook> BorrowBookList = new List<BorrowBook>();
            BorrowBookList.Add(borrowBooks);
        }
        public void BookReturn()
        {
            var returnbook = new ReturnBook();
            Console.WriteLine("Book Code:");
            returnbook.BookCode = (Console.ReadLine());
            Console.WriteLine("Return Book Quantity");
            returnbook.ReturnBookQuantity =int.Parse(Console.ReadLine());
            List<ReturnBook> ReturnBookList = new List<ReturnBook>();
            ReturnBookList.Add(returnbook);
        }
        public void DisplayBook()
        {
            Console.WriteLine("Code Name Author Remaining Stock");
            foreach( Book items in BookList)
            {
                Console.WriteLine(items.BookCode);
            }
        }
    }
}
