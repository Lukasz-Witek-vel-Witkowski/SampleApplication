﻿using System;
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
        private Product product;

        public Basket(){}
        public void addProduct(Product _product)
        {
            Sum += _product.getPrice();
            product = _product;
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
