using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace ResponsiPemrog2731
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, KeranjangEventListener
    {

        Penawaran penawaran = new Penawaran();
        public MainWindow()
        {
            InitializeComponent();

            Keranjang keranjangItem = new Keranjang();
            KeranjangController keranjangController = new KeranjangController(keranjangItem, this);


            ListItemBeli.ItemsSource = keranjangItem.findAll();

            ListItemBeli.Items.Refresh();
           
            

        }
        
       
            
        
        private void OnButtonAddItemClicked(object sender, RoutedEventArgs e)
        {
            Penawaran penawaran = new Penawaran();

            penawaran.Show();
        }

        private void OnButtonGantiAlamatClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnButtonGantiMetodePembayranClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnButtonGantiPromoCLicked(object sender, RoutedEventArgs e)
        {

        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListItemBeli.Items.Refresh();
        }
    }
}
