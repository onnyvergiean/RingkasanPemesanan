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
    {

        private Bucket bucket;
        double subTotal = 0, saldo = 50000;
        public MainWindow()
        {
            
            InitializeComponent();

            bucket = new Bucket();
            ListItem.ItemsSource = bucket.GetItems();
            ListItem.Items.Refresh();
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



        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
           
            ListItemBeli.Items.Add(ListItem.SelectedItem);
            if(ListItem.SelectedIndex == 0)
            {
                subTotal += 5000;
                saldo -= 5000;
            }else if(ListItem.SelectedIndex == 1)
            {
                subTotal += 3000;
                saldo -= 3000;
            }
            else if (ListItem.SelectedIndex == 2)
            {
                subTotal += 5000;
                saldo -= 5000;
            }
            else if (ListItem.SelectedIndex == 3)
            {
                subTotal += 10000;
                saldo -= 10000;
            }
            else if (ListItem.SelectedIndex == 4)
            {
                subTotal += 12000;
                saldo -= 12000;
            }
            else
            {
                subTotal += 15000;
                saldo -= 15000;
            }
            SubTotal.Content = String.Format("{0}",subTotal);
            Saldo.Content = String.Format("{0}", saldo);
            TotalHarga.Content = String.Format("{0}", subTotal + 10000);
        }
    }
}
