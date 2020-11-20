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
    public partial class MainWindow : Window


        

        public MainWindow()
        {
            
            InitializeComponent();

            List<Item> item = new List<Item>();
            item.Add(new Item() { nama = "Jeruk", harga = 5000 });
            item.Add(new Item() { nama = "Ice Tea", harga = 3000 });
            item.Add(new Item() { nama = "Ice Lemon", harga = 5000 });
            item.Add(new Item() { nama = "Bakso", harga = 10000 });
            item.Add(new Item() { nama = "Gado - Gado", harga = 12000 });
            item.Add(new Item() { nama = "Sate", harga = 15000 });
            ListItem.ItemsSource = item;
            ListItem.Items.Refresh();


            ListItemBeli.Items.Refresh();
            
            ListItemBeli.Items.Refresh();
        }
        
        



        private void OnButtonAddItemClicked(object sender, RoutedEventArgs e)
        {
            Penawaran penawaran = new Penawaran();

            penawaran.Show();
        }

        private void OnButtonGantiAlamatClicked(object sender, RoutedEventArgs e)
        {
            GantiAlamat gantiAlamat = new GantiAlamat();
            gantiAlamat.Show();
        }

        private void OnButtonGantiMetodePembayranClicked(object sender, RoutedEventArgs e)
        {
            MetodePembayaran metodePembayaran = new MetodePembayaran();
            metodePembayaran.Show();
        }

        private void OnButtonGantiPromoCLicked(object sender, RoutedEventArgs e)
        {
            GantiPromo gantiPromo = new GantiPromo();
            gantiPromo.Show();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListItemBeli.Items.Refresh();
        }

        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListItemBeli.Items.Add(ListItem.SelectedItem);
        }
    }
}
