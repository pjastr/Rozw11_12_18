using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rozw11_12_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Przycisk_Click(object sender, RoutedEventArgs e)
        {
            double liczba1 = Convert.ToDouble(Liczba1.Text);
            double liczba2 = Convert.ToDouble(Liczba2.Text);
            double wynik = liczba1 + liczba2;
            Wynik.Content = wynik.ToString();
        }
    }
}
