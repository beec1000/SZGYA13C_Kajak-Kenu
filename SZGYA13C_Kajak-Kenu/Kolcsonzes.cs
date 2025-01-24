using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA13C_Kajak_Kenu
{
    public class Kolcsonzes
    {
        public string Nev { get; set; }
        public int HajoID { get; set; }
        public string HajoTipus { get; set; }
        public int Szemelyek { get; set; } //1, 2, 3 vagy 4
        public int ElvitelOra { get; set; } //6-21
        public int ElvitelPerc { get; set; } //0-59
        public int VisszaOra { get; set; } //6-21
        public int VisszaPerc { get; set; } //0-59

        public Kolcsonzes(string nev, int hId, string hTipus, int szemelyek, int elOra, int elPerc, int viszzaOra, int visszaPerc)
        {
            Nev = nev;
            HajoID = hId;
            HajoTipus = hTipus;
            Szemelyek = szemelyek;
            ElvitelOra = elOra;
            ElvitelPerc = elPerc;
            VisszaOra = viszzaOra;
            VisszaPerc = visszaPerc;
        }

        public static List<Kolcsonzes> Fromfile(string p)
        {
            List<Kolcsonzes> kolcsonzes = new List<Kolcsonzes>();

            string[] lines = File.ReadAllLines(p);

            foreach (var l in lines.Skip(1))
            {
                string[] v = l.Split(';');

                string Nev = v[0];
                int HajoID = int.Parse(v[1]);
                string HajoTipus = v[2];
                int Szemelyek = int.Parse(v[3]);
                int ElvitelOra = int.Parse(v[4]);
                int ElvitelPerc = int.Parse(v[5]);
                int VisszaOra = int.Parse(v[5]);
                int VisszaPerc = int.Parse(v[6]);
                

                Kolcsonzes kolcsonzesek = new(Nev, HajoID, HajoTipus, Szemelyek, ElvitelOra, ElvitelPerc, VisszaOra, VisszaPerc);
                kolcsonzes.Add(kolcsonzesek);
            }

            return kolcsonzes;
        }

        public override string ToString()
        {
            return $"{Nev}, {HajoID}, {HajoTipus}, {Szemelyek}, {ElvitelOra}, {ElvitelPerc}, {VisszaOra}, {VisszaPerc}";
        }


    }
}
