using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal abstract class LibraryItem:program
    {
        public string _title {get; set;}
        public string _author { get; set; }
       public int _year { get; set; }

        public LibraryItem(string title, string author ,int year)
        {
            _title = title;
            _author = author;
            _year = year;


        }

       public abstract void Displayinfo();

       
        
    }
}
