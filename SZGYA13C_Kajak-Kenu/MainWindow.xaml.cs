using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;

namespace SZGYA13C_Kajak_Kenu
{
    public partial class MainWindow : Window
    {
        List<Kolcsonzes> kolcsonzes = new List<Kolcsonzes>();
        public MainWindow() 
        { 
            InitializeComponent();

            kolcsonzes = Kolcsonzes.Fromfile(@"..\..\..\src\kolcsonzes.txt");
            OsszDG.ItemsSource = kolcsonzes;

            var elvitelIdo = kolcsonzes.Select(o => $"{o.ElvitelOra}:{o.ElvitelPerc}");
            idoCB.ItemsSource = elvitelIdo;

        }

        public void HajoVizen(int Ora, int Perc)
        {
            int jelenIdoOra = DateTime.Now.Hour;
            int jelenIdoPerc = DateTime.Now.Minute;

            var vizen = kolcsonzes.Where(v => v).ToList();
        }

        private void idoCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var k = idoCB.SelectedItem.ToString().Split(":");
            int keresettOra = int.Parse(k[0]);
            int keresettPerc = int.Parse(k[1]);
            HajoVizen(keresettOra, keresettPerc);
        }
    }
}
