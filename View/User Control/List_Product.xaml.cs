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
    /// Interaction logic for List_Product.xaml
    /// </summary>
    public partial class List_Product : UserControl
    {
        private string Type;


        public BitmapImage Thumb
        {
            get { return (BitmapImage)GetValue(ThumbProperty); }
            set { SetValue(ThumbProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Thumb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThumbProperty =
            DependencyProperty.Register("Thumb", typeof(BitmapImage), typeof(List_Product));


        public string typeName
        {
            get { return (string)GetValue(typeNameProperty); }
            set { SetValue(typeNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for typeName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty typeNameProperty =
            DependencyProperty.Register("typeName", typeof(string), typeof(List_Product), new PropertyMetadata("No Type"));



        private List<Product> listproduct = new List<Product>();
        public List_Product(string type)
        {
            this.Type = type;
            if (type == "Jacket")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/jacket.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (type == "T_Shirt")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/t-shirt.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (type == "Sweater")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/sweater.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (type == "Jean")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/pants.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (type == "Shirt")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/short.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (type == "Bag")
            {
                typeName = "#" + type;
                Thumb = new BitmapImage(new Uri("../../image/category/bag.jpg", UriKind.RelativeOrAbsolute));
            }
            InitializeComponent();
            GetProduct();
        }
        public void GetProduct()
        {
            listproduct = Productdatabase.GetProductByType(Type);
            lvDataBinding.ItemsSource = listproduct;
        }
    }
}
