using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        List<Class1> nobel = new List<Class1>();
        static void Main(string[] args)
        { 
            StreamReader sr = new StreamReader(args[0]);
            string[] data = sr.ReadLine().Split(';');
            Console.WriteLine("4. feladat: ");  where(x => x.evszam == "2017") ;
            Console.WriteLine("6. feladat: "); where(x => x.vNev == "Curie");
            Console.WriteLine("7. feladat: "); where ;
            sr.Close();              
        }

    }
}
