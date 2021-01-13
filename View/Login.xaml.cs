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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using View.Classess;
using View.Database;
using View.Utils;


namespace View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string Phone_number { get; private set; }
        public string Password { get; private set; }

        public Login()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

       

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            LoginUser lu = new LoginUser(tbPhone.Text.Trim(), pbBox.Password.Trim());
            if (tbPhone.Text.Trim() == "admin" && pbBox.Password.Trim() == "admin")
            {

                AdminWindow Dinhtam = new AdminWindow();
                Window.GetWindow(this).Hide();
                Dinhtam.Show();
            }
            else
            {
                if (Accountdatabase.CheckAccount(lu.Phone_number, lu.Password))
                {
                    MainWindow m = new MainWindow(lu.Phone_number);
                    Window.GetWindow(this).Hide();
                    m.Show();
                }
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            Window.GetWindow(this).Close();
        }
    }
}
