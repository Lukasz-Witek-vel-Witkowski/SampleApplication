using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.SQL
{
    public class SqlTableProducts
    {
        List<QueryProduct> list;
       public SqlTableProducts()
        {

        }
        public void add(SqlDataReader sqlDataReader)
        {
            QueryProduct queryProduct = new QueryProduct();
            queryProduct.Name = sqlDataReader["Name"].ToString();
            queryProduct.ID = sqlDataReader["ID"].ToString();
            queryProduct.Number = sqlDataReader["Number"].ToString();
            queryProduct.Description = sqlDataReader["Description"].ToString();
            queryProduct.Price = sqlDataReader["Price"].ToString();
            queryProduct.Image = sqlDataReader["Image"].ToString();
            list.Add(queryProduct);
        }

        public int Size()
        {
            return list.Count;
        }
       
        public Product getProduct(int index)
        {
         
            if (list.Count > index) {
                Product product;
                QueryProduct queryProduct = list.ElementAt(index);
                product = new Product(queryProduct.Name,
                    ulong.Parse(queryProduct.Number),
                    double.Parse(queryProduct.Price),
                    queryProduct.Description,
                    ulong.Parse(queryProduct.ID),
                    queryProduct.Image);
                return product;
            }
            return null;
        }
    }

    internal class QueryProduct
    {
        public String Name { get; set; }
        public String ID { get; set; }
        public String Description { get; set; }
        public String Price { get; set; }
        public String Number { get; set; }
        public String Image { get; set; }
       public QueryProduct() { }
    }
}
