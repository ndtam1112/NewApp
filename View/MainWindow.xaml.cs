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
using View.User_Control;

namespace View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string PhoneNumber;
        public MainWindow(string phone)
        {
            this.PhoneNumber = phone;
            InitializeComponent();
        }
        #region Close, Minimize and 4 Button Mặc Định
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            HomeLayout.Children.Clear();
            HomeLayout.Children.Add(new Category());

        }
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomeLayout.Children.Clear();
            HomeLayout.Children.Add(new Home());
        }
        
        private void btnMe_Click(object sender, RoutedEventArgs e)
        {
            HomeLayout.Children.Clear();
            HomeLayout.Children.Add(new Account(PhoneNumber));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string text = search.Text.Trim();
            search.Text = "";
            HomeLayout.Children.Clear();
            HomeLayout.Children.Add(new ProductDetail(text));
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }




        #endregion

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            HomeLayout.Children.Clear();
            HomeLayout.Children.Add(new Cart(PhoneNumber));
        }
    }
}
