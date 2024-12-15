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
            if (_currentPage == _numberOfPages)
            {
                Console.WriteLine("Wow, posledni stranka knizky");
            }
            if (_currentPage > _numberOfPages)

            {
                Console.WriteLine("Jde videt, ze jsi knizku necetl, tato kniha ma " + _numberOfPages + " stran");
                _currentPage = 0; // Ve vypisu bude 0/_numberOfPages (chci vypsat ze vim ze to necet)
                // nebo jde nastavit jak si psal na maximalni validni hodnotu pomoci: _currentPage = _numberOfPages;
            }
            else if (_currentPage < 0)
            {
                Console.WriteLine("Nejde precist minus pocet stran");
                _currentPage = 0;
            }
            
            
        }
        public void DisplayProgress()
        {
            
            Console.WriteLine("Reading the " + _title + " by " + _author + " "+ _currentPage + "/" + _numberOfPages + " pages read.");
        }
    }



}
