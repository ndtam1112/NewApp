using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using View.Database;

namespace View
{
    public class ProductDetailModel
    {
        private string _name_product;
        private double _price_product;
        private string _id_product;
        private string _category_product;
        private BitmapImage _image_product;
        private BitmapImage _image_product1;
        private BitmapImage _image_product2;

        public string Name_product { get => _name_product; set => _name_product = value; }
        public double Price_product { get => _price_product; set => _price_product = value; }
        public string Id_product { get => _id_product; set => _id_product = value; }
        public string Category_product { get => _category_product; set => _category_product = value; }
        public BitmapImage Image_product { get => _image_product; set => _image_product = value; }
        public BitmapImage Image_product1 { get => _image_product1; set => _image_product1 = value; }
        public BitmapImage Image_product2 { get => _image_product2; set => _image_product2 = value; }

        public ProductDetailModel(string name_product, double price_product, string id_product, string category_product, BitmapImage image_product, BitmapImage image_product1, BitmapImage image_product2)
        {
            Name_product = name_product;
            Price_product = price_product;
            Id_product = id_product;
            Category_product = category_product;
            Image_product = image_product;
            Image_product1 = image_product1;
            Image_product2 = image_product2;
        }

        public ProductDetailModel()
        {
            
        }
    }
}
