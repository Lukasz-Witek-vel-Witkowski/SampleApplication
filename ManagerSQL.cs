using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Diagnostics;
using SampleApplication.SQL;

namespace SampleApplication
{
    class ManagerSQL
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        private String Addres;
        private String Database;
        private String User;
        private String Password;
        private SqlTableProducts sqlTableProducts;
        public ManagerSQL(string addres, string database, string user, string password)
        {
            Addres = addres;
            Database = database;
            User = user;
            Password = password;
            sqlTableProducts = new SqlTableProducts();
        }
        public void connect()
        {
            String data ="";
            try
            {
            //    sqlConnection = new SqlConnection(data);
           //     sqlConnection.Open();
            }
            catch (SqlException e)
            {
                Debug.WriteLine("Error Connect DataBase");
                Debug.WriteLine(e.Message);
            }
        }
        public void querry(String data)
        {
            try
            {
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = data;
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlTableProducts.add(sqlDataReader);
                sqlDataReader.Close();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        public SqlTableProducts GetSqlTableProducts()
        {
            return sqlTableProducts;
        }
    }

}
