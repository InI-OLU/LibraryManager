using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal class Book:LibraryItem
    {

        bool _IsBorrowed { get; set; }
        string _BorrowedBy { get; set; }


        public Book(string BorrowedBy, bool IsBorrowed, string title, string author, int year): base (title, author, year)
        {
            _BorrowedBy = BorrowedBy;
            _IsBorrowed = IsBorrowed;
        }
        public override void Displayinfo()
        {
            Console.WriteLine($"Book : {_title} ");
            Console.WriteLine($"Author : {_author} ");
            Console.WriteLine($"Year : {_year} ");
            Console.WriteLine($"Borrowed By : {_BorrowedBy} ");
            Console.WriteLine($"Borrowed : {_IsBorrowed} ");
        }

   





    }
}
