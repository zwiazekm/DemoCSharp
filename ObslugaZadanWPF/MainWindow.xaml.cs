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
using Szkolenie.Zadania;

namespace ObslugaZadanWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZarzadcaZadan zz = new ZarzadcaZadan();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = demoText.Text;
        }

        private void DodajZadanie_Click(object sender, RoutedEventArgs e)
        {
            //Wyświetlenie okna
            ZadanieForm zadanieForm = new ZadanieForm();
            zadanieForm.Title = "Nowe zadanie";
            bool? wynik = zadanieForm.ShowDialog();
            //Odebranie danych
            var tytul = zadanieForm.txtTytuł.Text;
            var termin = zadanieForm.dtTerminZadania.SelectedDate.Value;
            Zadanie noweZadanie = new Zadanie(tytul, termin);
            zz.DodajZadanie(noweZadanie);
            listBox.ItemsSource = zz.ZadaniaNieZakonczone();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = zz.ZadaniaNieZakonczone();
            
        }
    }
}
