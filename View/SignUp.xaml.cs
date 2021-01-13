using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using View.Database;

namespace View
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public object Userdatabase { get; private set; }

        public SignUp()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void btSkip_Click(object sender, RoutedEventArgs e)
        {
            Grid1.Opacity = 1;
            txtSignUp.Opacity = 1;
            tb1.Opacity = 0;
            tb2.Opacity = 0;
            tb3.Opacity = 0;
            tb4.Opacity = 0;
            btnSkip.Opacity = 0;
        }

        private void btnWantSignin_Click(object sender, RoutedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private Boolean  ktra()
        {
            if (phoneSignUp.Text.Equals("") || passWordSignUp.Password.Equals("") || passWordSignUp2.Password.Equals(""))
            {
                MessageBox.Show("ERROR:account or password is blank");
                return false;
            }

            return true;
        }
        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
           if(ktra())
            {
                if (passWordSignUp.Password == passWordSignUp2.Password)
                {
                    if (Accountdatabase.insert(phoneSignUp.Text.Trim(), passWordSignUp.Password.Trim()))
                    {
                        if (Clientdatabase.InsertToClient(phoneSignUp.Text.Trim(), "", ""))
                            MessageBox.Show("Sign Up Success!");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed");
                    }
                }
                else
                {
                    MessageBox.Show("That password doesn't match, please re-enter it!");
                }
            }
           
        }

        private void phoneSignUp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
