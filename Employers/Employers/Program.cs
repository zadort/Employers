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
            #region 2. feladat
            List<Class1> lista = new List<Class1>();
            #endregion

                
            #region 1. feladat
            var sorok = File.ReadAllLines("tulajdonsagok_100sor.txt");
            #endregion

            foreach (var sor in sorok)
            {
                lista.Add(new Class1(sor));
            }

            #region 3.feladat
            Console.WriteLine("3. feladat");
            Console.WriteLine("ÖSSZES NÉV");
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.nev}");
            }
            Console.WriteLine();
            #endregion

            #region 4. feladat
            Console.WriteLine("4. feladat");
            Console.WriteLine("DOLGOZÓK AKIK A LEGJOBBAN KERESNEK");
            Class1 legnagyobbKereset = lista[0];
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].kereset > legnagyobbKereset.kereset)
                {
                    legnagyobbKereset = lista[i];
                }    
            }
            Console.WriteLine($"Azonosító: {legnagyobbKereset.azonosito} | Név: {legnagyobbKereset.nev}");
            Console.WriteLine();
            #endregion

            #region 5. feladat
            Console.WriteLine("5. feladat");
            Console.WriteLine("AKIKNEK 10 ÉVÜK VAN A NYUGDÍJIG");
            foreach (var item in lista)
            {
                if (55 == item.kor)
                {
                    Console.WriteLine($"Név: {item.nev} | Kor: {item.kor}");
                }
            }
            Console.WriteLine();
            #endregion

            #region 6. feladat
            Console.WriteLine("6. feladat");
            Console.WriteLine("HÁNYAN KERESNEK 50000FT FELETT");
            int db = 0;
            foreach (var item in lista)
            {
                if (item.kereset >= 50000)
                {
                    db++;
                }
            }
            Console.WriteLine($"{db} személy");
            #endregion

            Console.ReadLine();
        }
    }
}
