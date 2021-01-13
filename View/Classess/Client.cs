using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Classess
{
    public class Client
    {
        private string _name_client;
        private string _phone_number;
        private string _address_client;

        public string Name_client { get => _name_client; set => _name_client = value; }
        public string Phone_number { get => _phone_number; set => _phone_number = value; }
        public string Address_client { get => _address_client; set => _address_client = value; }

        public Client(string name_client, string phone_number, string address_client)
        {
            Name_client = name_client;
            Phone_number = phone_number;
            Address_client = address_client;
        }
        public Client()
        {

        }
    }
}
