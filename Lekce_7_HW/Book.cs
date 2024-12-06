using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lekce_7_HW
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _numberOfPages;
        private int _currentPage = 0;
        
        

        public Book(string title, string author, int numberOfPages)
        {
            _title = title;
            _author = author;
            _numberOfPages = numberOfPages;
        }

        public void Read(int pages)
        {
        _currentPage += pages;
            if (_currentPage >= _numberOfPages || _currentPage < 0)
                {
                Console.WriteLine("Coze, vzdyt takova stranka v knizce ani neni");
                return;
                }
            else if (_currentPage == _numberOfPages) {
                Console.WriteLine("Wow, posledni stranka knizky");   
            }
            Console.WriteLine("Přečetl jsi: " + _currentPage + " stran.");
        }
        public void DisplayProgress()
        {
            Console.WriteLine("Reading the " + _title + " by " + _author + " "+ _currentPage + "/" + _numberOfPages + " pages read.");
        }
    }



}
