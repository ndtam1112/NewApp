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
using View.Classess;
using View.Database;

namespace View.User_Control
{
    /// <summary>
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : UserControl
    {


        public string phone
        {
            get { return (string)GetValue(phoneProperty); }
            set { SetValue(phoneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for phone.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty phoneProperty =
            DependencyProperty.Register("phone", typeof(string), typeof(Account));



        public string name
        {
            get { return (string)GetValue(nameProperty); }
            set { SetValue(nameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty nameProperty =
            DependencyProperty.Register("name", typeof(string), typeof(Account));



        public string address
        {
            get { return (string)GetValue(addressProperty); }
            set { SetValue(addressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for address.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty addressProperty =
            DependencyProperty.Register("address", typeof(string), typeof(Account));


        private string PhoneNumber;
        public Account(string phone)
        {
            this.PhoneNumber = phone;
            InitializeComponent();
            InitProfile();
        }

        private void InitProfile()
        {
            Client c = Clientdatabase.GetProfileClient(PhoneNumber);
            name = c.Name_client;
            phone = c.Phone_number;
            address = c.Address_client;

        }

        private void btnChangePass_Click(object sender, RoutedEventArgs e)
        {
            if (Accountdatabase.CheckAccount(phoneNumberto.Text.Trim(), passwordold.Text.Trim()))
            {
                if (passssword1.Password.Equals("")||password2.Password.Equals(""))
                {
                    MessageBox.Show("ERROR: account or password is blank");
                }
                else
                {
                    if (passssword1.Password == password2.Password)
                    {
                        Accountdatabase.UpdateToPassWord(phoneNumberto.Text.Trim(), passssword1.Password.Trim());
                        MessageBox.Show("Update Success!");
                    }
                    else MessageBox.Show("That password doesn't match, please re-enter it!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clientdatabase.UpdateToClient(Phone_clientt.Text.Trim(), Name_clientt.Text.Trim(), Address_clientt.Text.Trim());
            MessageBox.Show("Update Success!");
        }


    }
}
