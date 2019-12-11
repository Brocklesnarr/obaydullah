using System;

namespace Assignment_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ABC Library System");
            

            Console.WriteLine("1:Add Book");
            Console.WriteLine("2:Borrow Book");
            Console.WriteLine("3:Return Book");
            Console.WriteLine("4:Display List");
            Console.WriteLine("5:Exit");

            while (true)
            {
                Console.WriteLine("Please Select an Option:");
                int caseSwitch = int.Parse(Console.ReadLine());
                
                    switch (caseSwitch)
                    {
                    case 1:
                        AddBorrowReturnDisplayBook obj1 = new AddBorrowReturnDisplayBook();
                        obj1.BookAddition();
                        Console.WriteLine("Successfully Book Added in Library");
                        break;
                    case 2:
                        AddBorrowReturnDisplayBook obj2 = new AddBorrowReturnDisplayBook();
                        obj2.BookBorrow();
                        Console.WriteLine("Successfully Book Borrowed from Library");
                        break;
                    case 3:
                        AddBorrowReturnDisplayBook obj3 = new AddBorrowReturnDisplayBook();
                        obj3.BookReturn();
                        Console.WriteLine("Successfully Book Returned to Library");
                        break;
                    case 4:
                        AddBorrowReturnDisplayBook obj4 = new AddBorrowReturnDisplayBook();
                        obj4.DisplayBook();
                        break;
                    case 5: 
                        Console.WriteLine("Thank You for using ABC Library System");
                        break;
                    }
                if (caseSwitch == 5)
                    break;
                
            }
        }
    }
}
