using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    class Product
    {
        private string Name;   //Product Name
        private ulong Number;  //System number
        private double Price;  //Product Price
        private string Description; //Product Description
        private ulong ID;  //System ID
        private string Image;   //Photo address

        public Product(string name, ulong number,double price, ulong id)
        {
            Name = name;
            Number = number;
            Price = price;
            ID = id;
        }
        public Product(string name, ulong number, double price, string description, ulong id, string image)
        {
            Name = name;
            Number = number;
            Price = price;
            Description = description;
            ID = id;
            Image = image;
        }
        public string getName()
        {
            return Name;
        }

        public ulong getNumber()
        {
            return Number;
        }

        public double getPrice()
        {
            return Price;
        }

        public string getDescription()
        {
            return Description;
        }

        public ulong getID()
        {
            return ID;
        }

        public string getImage()
        {
            return Image;
        }

        public void setImage(string image)
        {
            Image = image;
        }
        public void setDescription(string description)
        {
            Description = description;
        }
    }
}
