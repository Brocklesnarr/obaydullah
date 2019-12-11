using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    public class Book
    {
        public string BookCode { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int x { get; set; }

        public List<BorrowBook> BorrowBooks { get; set; }
        public List<ReturnBook> ReturnBooks { get; set; }
    }
    
}
