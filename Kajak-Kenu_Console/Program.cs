using SZGYA13C_Kajak_Kenu;
using System.Linq;

namespace Kajak_Kenu_Console
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Kolcsonzes> kolcsonzes = new List<Kolcsonzes>();

            kolcsonzes = Kolcsonzes.Fromfile(@"..\..\..\..\SZGYA13C_Kajak-Kenu\src\kolcsonzes.txt");

            //4. feladat
            Console.WriteLine($"Összese {kolcsonzes.Count()} db kölcsönzés található.");

            //5. feladat
            Console.WriteLine("Kérek egy nevet:");
            string nev = Console.ReadLine();

            var kolcsonzo = kolcsonzes.Where(k => k.Nev.Contains(nev)).FirstOrDefault();

            Console.WriteLine($"{kolcsonzo.Nev} {kolcsonzo.ElvitelOra}:{kolcsonzo.ElvitelPerc}-tól/től, {kolcsonzo.VisszaOra}:{kolcsonzo.VisszaPerc}-ig bérelte a hajót.");

            //6. feladat
            var kulfoldiKolcsonzok = kolcsonzes.Where(k => k.Nev.Contains(',')).Count();
            var magyarKolcsonzok = kolcsonzes.Count() - kulfoldiKolcsonzok;

            Console.WriteLine($"{magyarKolcsonzok} magyar, és {kulfoldiKolcsonzok} külföldi vendég volt.");
        }
    }
}
