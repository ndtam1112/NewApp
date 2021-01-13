using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace View.Classess
{
    public class Image_Product
    {
        private string _id_product;
        private string _size_product;
        private string _amount_product;
        private BitmapImage _image_product;

        public string Id_product { get => _id_product; set => _id_product = value; }
        public string Size_product { get => _size_product; set => _size_product = value; }
        public string Amount_product { get => _amount_product; set => _amount_product = value; }
        public BitmapImage Image_product { get => _image_product; set => _image_product = value; }

        public Image_Product(string id_product, string size_product, string amount_product, BitmapImage image_product)
        {
            Id_product = id_product;
            Size_product = size_product;
            Amount_product = amount_product;
            Image_product = image_product;
        }

        public Image_Product()
        {
        }
    }
}
