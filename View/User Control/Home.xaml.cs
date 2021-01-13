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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {


        public BitmapImage Image1
        {
            get { return (BitmapImage)GetValue(Image1Property); }
            set { SetValue(Image1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image1Property =
            DependencyProperty.Register("Image1", typeof(BitmapImage), typeof(Home));



        public BitmapImage Image
        {
            get { return (BitmapImage)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(BitmapImage), typeof(Home));



        public BitmapImage Image2
        {
            get { return (BitmapImage)GetValue(Image2Property); }
            set { SetValue(Image2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Image2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Image2Property =
            DependencyProperty.Register("Image2", typeof(BitmapImage), typeof(Home));




        public Home() 
        {
            InitializeComponent();
            Image = Productdatabase.GetImageProductByID("JK002").Image_product;
            Image1 = Productdatabase.GetImageProductByID("JK003").Image_product;
            Image2 = Productdatabase.GetImageProductByID("SHI001").Image_product;
        }

        private void btnSale1_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow main = (MainWindow)Window.GetWindow(this);
            main.HomeLayout.Children.Clear();
            main.HomeLayout.Children.Add(new ProductDetail("JK003")); 
        }

        private void btnSale2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);
            main.HomeLayout.Children.Clear();
            main.HomeLayout.Children.Add(new ProductDetail("SHI001"));
        }

        private void btnSale3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);
            main.HomeLayout.Children.Clear();
            main.HomeLayout.Children.Add(new ProductDetail("JK002"));
        }
    }
}
