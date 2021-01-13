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
using View.Database;


namespace View.User_Control
{
    /// <summary>
    /// Interaction logic for SanPhamChiTiet.xaml
    /// </summary>
    public partial class ProductDetail : UserControl
    {

        public BitmapImage ImageMain
        {
            get { return (BitmapImage)GetValue(ImageMainProperty); }
            set { SetValue(ImageMainProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageMain.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageMainProperty =
            DependencyProperty.Register("ImageMain",
                typeof(BitmapImage),
                typeof(ProductDetail),
                new PropertyMetadata(new BitmapImage(new Uri($"../../image/category/jacket.jpg", UriKind.RelativeOrAbsolute))));


        public BitmapImage ImageSub1
        {
            get { return (BitmapImage)GetValue(ImageSub1Property); }
            set { SetValue(ImageSub1Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSub1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSub1Property =
            DependencyProperty.Register("ImageSub1",
                typeof(BitmapImage),
                typeof(ProductDetail),
                new PropertyMetadata(new BitmapImage(new Uri($"../../image/category/jacket.jpg", UriKind.RelativeOrAbsolute))));

        public BitmapImage ImageSub2
        {
            get { return (BitmapImage)GetValue(ImageSub2Property); }
            set { SetValue(ImageSub2Property, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSub1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSub2Property =
            DependencyProperty.Register("ImageSub2",
                typeof(BitmapImage),
                typeof(ProductDetail),
                new PropertyMetadata(new BitmapImage(new Uri($"../../image/category/jacket.jpg", UriKind.RelativeOrAbsolute))));


        public string NameProduct
        {
            get { return (string)GetValue(NameProductProperty); }
            set { SetValue(NameProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NameProduct.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProductProperty =
            DependencyProperty.Register("NameProduct", typeof(string), typeof(ProductDetail), new PropertyMetadata("No name"));



        public string CategoryProduct
        {
            get { return (string)GetValue(CategoryProductProperty); }
            set { SetValue(CategoryProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CategoryProduct.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CategoryProductProperty =
            DependencyProperty.Register("CategoryProduct", typeof(string), typeof(ProductDetail), new PropertyMetadata("No type"));

       





        private string IdProduct;
        public ProductDetail(string id)
        {
            IdProduct = id;
            initProductDetail();
            InitializeComponent();
            operationsProduct();
        }

        private void initProductDetail()
        {
            ProductDetailModel productDetail = Productdatabase.GetDetailProductByID(IdProduct);
            ImageMain = productDetail.Image_product;
            ImageSub1 = productDetail.Image_product1;
            ImageSub2 = productDetail.Image_product2;
            NameProduct = productDetail.Name_product;
            CategoryProduct = productDetail.Category_product;

        }

        private void operationsProduct()
        {
            btnPlus.Click += delegate (object sender, RoutedEventArgs e)
            {
                ProductDetailModel productDetail = Productdatabase.GetDetailProductByID(IdProduct);
                int temp = convertStringToInt(tbNumOfPro.Text) + 1;
                tbNumOfPro.Text = temp + "";
                tbPrice.Text = productDetail.Price_product * temp + "";
            };
            btnMinus.Click += delegate (object sender, RoutedEventArgs e)
            {
                ProductDetailModel productDetail = Productdatabase.GetDetailProductByID(IdProduct);
                int temp = convertStringToInt(tbNumOfPro.Text) - 1;
                if (temp < 0) temp = 0;
                tbNumOfPro.Text = temp + "";
               tbPrice.Text = productDetail.Price_product * temp + "";
            };

        }
        private int convertStringToInt(string item)
        {
            return Convert.ToInt32(item);
        }

        private void btnAddToHistory_Click(object sender, RoutedEventArgs e)
        {
            string id = IdProduct;
            byte status = 0;
            MainWindow main = (MainWindow)Window.GetWindow(this);
            string phone = main.PhoneNumber;
            try
            {
                int price = convertStringToInt(tbPrice.Text);
                string size = cbSize.SelectionBoxItem.ToString();
                if (size==null)
                {
                    MessageBox.Show("Please choose the size", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    string quantityText = tbNumOfPro.Text;
                    int quantity = convertStringToInt(quantityText);
                    if (quantity > 0)
                        if (Productdatabase.InsertToHistory(id, phone, status, size, quantity, price))
                            MessageBox.Show("Add to cart successfully~", "NOTIFY", MessageBoxButton.OK, MessageBoxImage.Information);
                        else
                            MessageBox.Show("Add to cart failure!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose quantity" + ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Window.GetWindow(this);
            mainwindow.HomeLayout.Children.Clear();
            mainwindow.HomeLayout.Children.Add(new Category());
        }
    }
}
