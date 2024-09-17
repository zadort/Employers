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
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.nev}");
            }
            #endregion

            #region 4. feladat
            int legnagyobbKereset = 0;
            foreach (var item in lista)
            {
                if (legnagyobbKereset >)
                {

                }
            }
            #endregion

            #region 5. feladat

            #endregion

            #region 6. feladat
            int db = 0;
            foreach (var item in lista)
            {
                if (item.kereset >= 50000)
                {
                    db++;
                }
            }
            Console.WriteLine(db);
            #endregion

            Console.ReadLine();
        }
    }
}
