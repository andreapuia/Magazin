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
using MagazinDAL.Models;
using MagazinDAL.Services;

namespace CursMagazin.Views
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            List<Client> c = new ClientServices().GetClientByCred(username, password);
            if (c.Count > 0)
            {
                Main main = new Main();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User doesnt exist.");
            }
        }
    }
}
