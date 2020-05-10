using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Model
{
    class ModelBasket
    {
        static ModelBasket instance;
        public static ModelBasket Instance()
        {
            if (instance == null)
                instance = new ModelBasket();
            return instance;
        }

        private Basket basket;

        public ModelBasket()
        {
            basket = new Basket();
        }
        public void setProduct(Product product)
        {
            basket.addProduct(product);
            
        }
        public double getSum()
        {
            return basket.getSum();
        }

    }
}
