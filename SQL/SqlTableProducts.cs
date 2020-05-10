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
        List<Tuple<string, string, string, string, string, string>> list;
        public SqlTableProducts()
        {
            list = new List<Tuple<string, string, string, string, string, string>>();
        }
        public void add(SqlDataReader sqlDataReader)
        {

            while (sqlDataReader.Read())
            {
                list.Add(new Tuple<string, string, string, string, string, string>(
                                    sqlDataReader["ID"].ToString(),
                                    sqlDataReader["Name"].ToString(),
                                    sqlDataReader["Number"].ToString(),
                                    sqlDataReader["Descryption"].ToString(),
                                    sqlDataReader["Price"].ToString(),
                                    sqlDataReader["Image"].ToString()
                    ));
            }
        }

        public int Size()
        {
            return list.Count;
        }

        public Product getProduct(int number)
        {
            string data = number.ToString();
            Tuple<string, string, string, string, string, string> tuple;
            for (int i = 0; i < list.Count; i++)
            {
                tuple = list.ElementAt(i);
                if (tuple.Item3 == data)
                {
                    return new Product( tuple.Item2,
                                        tuple.Item3,
                                        tuple.Item5,
                                        tuple.Item4,
                                        tuple.Item1,
                                        tuple.Item6 
                                        );
                }
            }
            return null;

        }
    }

}
