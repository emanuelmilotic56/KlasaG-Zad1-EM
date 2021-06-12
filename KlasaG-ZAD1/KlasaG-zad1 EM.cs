using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaG_ZAD1
{
     public class Program
    {
        static void Main()
        {

            Console.WriteLine("Unesena vrijednost: ");


            int vrijednost = Convert.ToInt32(Console.ReadLine());
            KlasaG zbroj = new KlasaG();

            KlasaG umnozak = new KlasaG();
            Console.WriteLine("Zbroj unesenih vrijednosti: ");
            zbroj.f50(vrijednost);


            Console.Write("Umnozak unesenih vrijednosti ");
            umnozak.Plus10(vrijednost);


            Console.ReadKey();


        }
    }
}
