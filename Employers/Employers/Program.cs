using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace Employers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Class1> lista = new List<Class1>();
            var sorok = File.ReadAllLines("tulajdonsagok_100sor.txt");

            foreach (var sor in sorok)
            {
                lista.Add(new Class1(sor));
            }

            foreach (var item in lista)
            {
                Console.WriteLine($"{item.azonosito} {item.nev} {item.kor} {item.kereset}");
            }

            Console.ReadLine();
        }
    }
}
