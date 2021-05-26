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
using MagazinDAL.Models;
using MagazinDAL.Services;
namespace CursMagazin.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            ProductServices ps = new ProductServices();
            List<MagazinDAL.Models.Product> prods = ps.GetProducts();
            lvProducts.ItemsSource = prods;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = (Product)lvProducts.SelectedItem;
            ProductServices ps = new ProductServices();
            ps.DeleteProduct(p);
            lvProducts.ItemsSource = null;
            lvProducts.ItemsSource = ps.GetProducts();
        }
    }
}
