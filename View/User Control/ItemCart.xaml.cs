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
    /// Interaction logic for ListCart.xaml
    /// </summary>
    public partial class ItemCart : UserControl
    {
        public ItemCart()
        {
            InitializeComponent();
        }

        private void delCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            History history = button.DataContext as History;
            MessageBoxResult result = MessageBox.Show("Are you sure ?", "Notify", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Productdatabase.DeleteToHistory(history.Id_product);
                    MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
                    mainWindow.HomeLayout.Children.Clear();
                    mainWindow.HomeLayout.Children.Add(new Cart(mainWindow.PhoneNumber));
                    break;
            }
           
        }

        private void buyNow_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
