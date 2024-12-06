using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_7_HW
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _year;
        private int _mileAge;

        public Car(string brand, string model, int year, int mileAge)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _mileAge = mileAge;
        }
        public void Drive(int kilometres)
        {
            if (kilometres < 0)
            {
                Console.WriteLine("Ha! Někdo se nám tu snaží stočit tachometr!");
                return;
            }
            else if (kilometres == 0) {
                Console.WriteLine("Nic jsi neujel");
                return;
            }
            { 
            Console.WriteLine("Ujel jsi " + kilometres + "km.");
            Console.WriteLine("Stav tvého tachometru: ");
            Console.WriteLine(_mileAge + kilometres);
            }
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("Značka: "+ _brand +", model: "+ _model + ", rok výroby: "+_year+" a stav tachometru: " + _mileAge);
        }
    }
}
