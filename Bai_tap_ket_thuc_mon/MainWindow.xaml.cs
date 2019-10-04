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

namespace Bai_tap_ket_thuc_mon
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

        private void btnConCho_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("Gau gau, toi la con Cho" + " co mau long " + txtConCho.Text);
        }

        private void btnConMeo_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("Meo meo, toi la con Meo" + " co mau long " + txtConMeo.Text);
        }
    }
}
