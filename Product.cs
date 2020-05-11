using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class Product
    {
        private string Name;   //Product Name
        private string Number;  //System number
        private string Price;  //Product Price
        private string Description; //Product Description
        private string ID;  //System ID
        private string Image;   //Photo address


        public Product(string name, string number, string price, string description, string id, string image)
        {
            Name = name;
            Number = number;
            Price = price;
            Description = description;
            ID = id;
            Image = image;
        }

        internal void Clear()
        {
            Name = "";
            Number = "";
            Price = "";
            Description = "";
            ID = "";
            Image = "";
        }

        public string getName()
        {
            return Name;
        }

        public string getNumber()
        {
            return Number;
        }

        public string getPrice()
        {
            return Price;
        }

        public string getDescription()
        {
            return Description;
        }

        public string getID()
        {
            return ID;
        }

        public string getImage()
        {
            return Image;
        }

    }
}
