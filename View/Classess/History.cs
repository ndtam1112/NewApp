using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace View.Classess
{
    public class History
    {
        private string _id_product;
        private string _phone_number;
        private byte _status_product;
        private string _name_product;
        private int _price_product;
        private int _amount_product;
        private BitmapImage _image_product;
        private string _size_product;

        public string Id_product { get => _id_product; set => _id_product = value; }
        public string Phone_number { get => _phone_number; set => _phone_number = value; }
        public byte Status_product { get => _status_product; set => _status_product = value; }
        public string Name_product { get => _name_product; set => _name_product = value; }
        public int Price_product { get => _price_product; set => _price_product = value; }
        public int Amount_product { get => _amount_product; set => _amount_product = value; }
        public BitmapImage Image_product { get => _image_product; set => _image_product = value; }
        public string Size_product { get => _size_product; set => _size_product = value; }

        public History(string id_product, string phone_number, byte status_product, string name_product, int price_product,
            int amount_product, BitmapImage image_product, string size_product)
        {
            Id_product = id_product;
            Phone_number = phone_number;
            Status_product = status_product;
            Name_product = name_product;
            Price_product = price_product;
            Amount_product = amount_product;
            Image_product = image_product;
            Size_product = size_product;
        }

        public History()
        {
        }
    }
}
