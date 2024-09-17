using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employers
{
    internal class Class1
    {
        public int azonosito;
        public string nev;
        public int kor;
        public int kereset;

        public Class1(string sor)
        {
            string[] darabok = sor.Split(';');
            this.azonosito = Convert.ToInt32(darabok[0]);
            this.nev = darabok[1];
            this.kor = Convert.ToInt32(darabok[2]);
            this.kereset = Convert.ToInt32(darabok[3]);
        }
    }
}
