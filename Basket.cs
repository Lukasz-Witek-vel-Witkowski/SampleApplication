using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    class Basket
    {
        private double Sum;
        private DateTime dateTime;

        public Basket(){}
        public void addProduct(Product product)
        {
            Sum += product.getPrice();
        }
        public double getSum()
        {
            return Sum;
        }
        public void setDateTime(DateTime date)
        {
            dateTime = date;
        }
    }
}
