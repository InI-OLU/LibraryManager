using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal class Magazine:LibraryItem
    {
        int _ISN { set; get; }

        public Magazine(int ISN, string title, string author, int year) : base(title, author, year)
        {
            _ISN = ISN;
           
        }
        public override void Displayinfo()
        {
            Console.WriteLine($"Book : {_title} ");
            Console.WriteLine($"Book : {_author} ");
            Console.WriteLine($"Book : {_year} ");
            Console.WriteLine($"Book : {_ISN} ");

        }

     
    }
}
