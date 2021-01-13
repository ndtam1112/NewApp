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
using Microsoft.Win32;
using View.Database;

namespace View
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnAddThumb_Main_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(.jpg,.png)|*.jpg;*.png;*.jpeg|*.gif|All";
            dialog.Title = "Select Image";
            dialog.Multiselect = false;
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == true)
            {
                filePathImage = dialog.FileName;
                Image_product_main.Source = new BitmapImage(new System.Uri(filePathImage, System.UriKind.RelativeOrAbsolute));
            }
        }

        private string filePathImage;
        private string filePathImage1;
        private string filePathImage2;

        private void btnAddThumb2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(.jpg,.png)|*.jpg;*.png;*.jpeg|*.gif|All";
            dialog.Title = "Select Image";
            dialog.Multiselect = false;
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == true)
            {
                filePathImage1 = dialog.FileName;
                Image_Sub_1.Source = new BitmapImage(new System.Uri(filePathImage1, System.UriKind.RelativeOrAbsolute));
            }
        }

        private void btnAddThumb3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(.jpg,.png)|*.jpg;*.png;*.jpeg|*.gif|All";
            dialog.Title = "Select Image";
            dialog.Multiselect = false;
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == true)
            {
                filePathImage2 = dialog.FileName;
                Image_Sub_2.Source = new BitmapImage(new System.Uri(filePathImage2, System.UriKind.RelativeOrAbsolute));
            }
        }

        private void btnAdd_product_Click(object sender, RoutedEventArgs e)
        {
            if(Productdatabase.checkProduct(Id_product.Text.Trim()))
            {
                string phrase = cbCategory.SelectedItem.ToString();
                string[] kq = phrase.Split(' ');
                if (Productdatabase.insertProduct(Id_product.Text.Trim(), Name_product.Text.Trim(), Price_product.Text.Trim(), kq[1]))
                {
                    MessageBoxResult result = MessageBox.Show("san pham nay chua co truoc do, ban co muon them ?", "Notify", MessageBoxButton.YesNo);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            Productdatabase.insertImage(Id_product.Text.Trim(), "M", Mount_product.Text.Trim(), new BitmapImage(new System.Uri(filePathImage, System.UriKind.RelativeOrAbsolute)));
                            Productdatabase.insertImage(Id_product.Text.Trim(), "L", Mount_product.Text.Trim(), new BitmapImage(new System.Uri(filePathImage1, System.UriKind.RelativeOrAbsolute)));
                            Productdatabase.insertImage(Id_product.Text.Trim(), "XL", Mount_product.Text.Trim(), new BitmapImage(new System.Uri(filePathImage2, System.UriKind.RelativeOrAbsolute)));
                            MessageBox.Show("insert product success!");
                            break;
                    }
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("san pham nay da co truoc do, ban co muon chinh sua ?", "Notify", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Productdatabase.UpdateToProduct(Id_product.Text.Trim(), Name_product.Text.Trim(), Price_product.Text.Trim());
                        Productdatabase.UpdateToImage(Id_product.Text.Trim(), Mount_product.Text.Trim());
                        MessageBox.Show("update product success!");
                        break;
                }
            }
        }
    }
}
