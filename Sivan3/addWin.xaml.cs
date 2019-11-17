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

namespace Sivan3
{
    /// <summary>
    /// Interaction logic for addWin.xaml
    /// </summary>
    public partial class addWin : Window
    {
        private barbercontroler bc = new barbercontroler();
        public addWin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = b1.Text;
            string g = b2.Text;
            string p = b3.Text;
            string a = b4.Text;

            bc.addbar(n, g, p, a);
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
