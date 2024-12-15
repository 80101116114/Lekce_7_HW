namespace Lekce_7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Car auticko = new Car("Toyota", "Corolla", 2015, 18500);
            auticko.DisplayCarInfo();
            Console.Write("Jak dlouhá bude tvá cestav v km?");
            string CestaVkm = Console.ReadLine();
            int CestaVkmInt = int.Parse(CestaVkm);
            auticko.Drive(CestaVkmInt);
            


            Book knizka = new Book("1984", "George Orwell", 316);
            Console.Write("Kolik jsi už přečetl stran?");
            string PocetStran = Console.ReadLine();
            int PocetStranInt= int.Parse(PocetStran);
            knizka.Read(PocetStranInt);
            knizka.DisplayProgress();
           
        }

    }
}
