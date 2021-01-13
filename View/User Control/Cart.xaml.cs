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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : UserControl
    {
        private List<History> listCart = new List<History>();
        private string Phone;
        public Cart(string phone)
        {
            Phone = phone;
            InitializeComponent();
            GetCart();
        }
        public void GetCart()
        {
            listCart = Productdatabase.GetProductInHistory(Phone);
            lvCart.ItemsSource = listCart;
            int sumMoney = 0;
            foreach(History item in listCart)
                sumMoney += item.Price_product;
            tbPriceSumAll.Text = sumMoney + "";
        }

        private void btnBuyNow_Click(object sender, RoutedEventArgs e)
        {
            //đổi status từ 0 sang 1
            //Productdatabase.UpdateStatusHistory()
        }
    }
}
