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
using System.Windows.Shapes;

namespace DiseñoEstilo
{
    /// <summary>
    /// Lógica de interacción para MenuMD.xaml
    /// </summary>
    public partial class MenuMD : Window
    {
        public MenuMD()
        {
            InitializeComponent();
        }

        private void Volver(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Conmando");
        }
    }
}
