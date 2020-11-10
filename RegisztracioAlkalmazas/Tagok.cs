using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Tagok
    {
        string nev;
        int szulev;
        string nem;
        string ujhobbi;

        public Tagok(string nev, int szulev, string nem, string ujhobbi)
        {
            this.Nev = nev;
            this.Szulev = szulev;
            this.Nem = nem;
            this.Ujhobbi = ujhobbi;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szulev { get => szulev; set => szulev = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Ujhobbi { get => ujhobbi; set => ujhobbi = value; }

        public string Sor()
        {
            return string.Format($"{nev},{szulev},{nem},{ujhobbi}");
        }
    }
}
