using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Libreria;

namespace Triangoli
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Lato1.Text != " " && txt_Lato2.Text != " " && txt_Lato3.Text != " ")
            {
                try
                {
                    double lato1 = double.Parse(txt_Lato1.Text);
                    double lato2 = double.Parse(txt_Lato2.Text);
                    double lato3 = double.Parse(txt_Lato3.Text);

                    lbl_TipoTriangolo.Content = Gestione.RiconosciTriangoli(lato1, lato2, lato3);
                    lbl_Area.Content = Gestione.Area(lato1, lato2, lato3);
                    lbl_Perimetro.Content = Gestione.Perimetro(lato1, lato2, lato3);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valori non validi!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito valori!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
