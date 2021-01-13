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

namespace View.User_Control
{
    /// <summary>
    /// Interaction logic for ItemProduct.xaml
    /// </summary>
    public partial class ItemProduct : UserControl
    {
        public ItemProduct()
        {
            InitializeComponent();
        }

        private void btnViewProductDetail_Click(object sender, RoutedEventArgs e)
        {
            Button buttonContext = sender as Button;
            Product pr = buttonContext.DataContext as Product;
            MainWindow pannel = (MainWindow)Window.GetWindow(this);
            pannel.HomeLayout.Children.Clear();
            ProductDetail detailProduct = new ProductDetail(pr.Id_product);
            pannel.HomeLayout.Children.Add(detailProduct);
        }

        
    }
}
