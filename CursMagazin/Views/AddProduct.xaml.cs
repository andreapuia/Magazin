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
using MagazinDAL.Services;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using log4net;
using log4net.Config;
using System.IO;

namespace CursMagazin.Views
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        FileStream fs = new FileStream("../../log4net.config", FileMode.Open);
        private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public AddProduct()
        {
            InitializeComponent();
            XmlConfigurator.Configure(fs);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            logger.Info("New product has been added to DB " + txtName.Text);
            logger.Error("Error after product has been added to DB " + txtName.Text);
            logger.Warn("Warn after error on product added to DB " + txtName.Text);
            ProductServices ps = new ProductServices();
            try { 
                ps.AddProduct(txtName.Text, txtPrice.Text);

                MessageBox.Show("Product added");
            }
            catch(Exception ex)
            {
                logger.Error("Error on adding product " + ex);
                MessageBox.Show("Error on adding the product to DB");
                Main main = new Main();
                main.Show();
                this.Close();
            }
            
        }
    }
}
