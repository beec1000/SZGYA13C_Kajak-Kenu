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

namespace SZGYA13C_Kajak_Kenu
{
    public partial class MainWindow : Window
    {
        List<Kolcsonzes> kolcsonzes = new List<Kolcsonzes>();
        public MainWindow()
        {
            InitializeComponent();

            kolcsonzes = Kolcsonzes.Fromfile(@"..\..\..\src\kolcsonzes.txt");

            test.Content = $"{kolcsonzes.Count}";
        }
    }
}