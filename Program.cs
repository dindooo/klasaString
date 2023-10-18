using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danas radimo sa klasom string";
            //ispis stringa
            Console.WriteLine(tekst);

            //broj znakova u stringu
            Console.WriteLine("Broj znakova je " +tekst.Length);

            //Velika slova
            Console.WriteLine("Velika slova : "+tekst.ToUpper());

            //Mala slova
            Console.WriteLine("Mala slova : "+tekst.ToLower());

            Console.WriteLine("\n -- Substring metoda --");
            Console.WriteLine(tekst.Substring(0, 5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));

            //Zamjena znakova
            Console.WriteLine("\n -- Zamjena znakova --");
            Console.WriteLine(tekst.Replace("Danas", "Sutra"));

            //Razdvajanje stringa u više njih
            Console.WriteLine("\n -- Razdvajanje --");
            string[] rjeci = tekst.Split(' ');
            for(int i = 0; i < rjeci.Length; i++)
            {
                Console.WriteLine(rjeci[i]);
            }

            foreach(string rijeci in rjeci)
            {
                Console.WriteLine(rijeci);
            }

            //Umetanje znakova u string
            Console.WriteLine("\n -- Umetanje znakova --");
            Console.WriteLine(tekst.IndexOf("Radimo"));

            Console.WriteLine(tekst.Insert(tekst.IndexOf("Radimo"), "intenzivno"));

            Console.ReadKey();
        }
    }
}
