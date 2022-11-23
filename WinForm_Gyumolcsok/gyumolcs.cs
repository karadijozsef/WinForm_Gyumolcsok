using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Gyumolcsok
{
    internal class gyumolcs
    {
        int id;
        string nev;
        double mennyiseg;
        double egysegar;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }

        public gyumolcs(int id, string nev, double mennyiseg, double egysegar)
        {
            Id = id;
            Nev = nev;
            Mennyiseg = mennyiseg;
            Egysegar = egysegar;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
