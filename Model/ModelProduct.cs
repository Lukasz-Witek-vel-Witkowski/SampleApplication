using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Model
{
    class ModelProduct
    {
        static ModelProduct instance;
        public static ModelProduct get()
        {
            if (instance == null)
                instance = new ModelProduct();
            return instance;
        }

        private Product product;

        public ModelProduct()
        {
        }
        public void setProduct(Product pro)
        {
            product = pro;
        }
        public Product getProduction()
        {
            return product;
        }

    }
}
