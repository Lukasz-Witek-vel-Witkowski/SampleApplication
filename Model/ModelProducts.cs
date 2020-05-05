using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Model
{
    class ModelProducts
    {
        static ModelProducts instance;
        public static ModelProducts get()
        {
            if (instance == null)
                instance = new ModelProducts();
            return instance;
        }
        private List<Product> Products;

        public ModelProducts()
        {
            Products = new List<Product>();
        }
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public Product[] getProducts()
        {
            return Products.ToArray();
        }
    }
}
