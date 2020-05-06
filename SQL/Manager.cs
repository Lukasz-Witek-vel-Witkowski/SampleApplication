using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication.SQL
{
    class Manager
    {
        private ManagerSQL sql;
        private string Database;
        private string User;
        private string Password;
        private string Address;
        public Manager(String Path)
        {
            load(Path);
        }

        private void load(String Path)
        {
            if(File.Exists(Path)){
                StreamReader streamReader = new StreamReader(Path);
                String s;
                do
                {
                    s = streamReader.ReadLine();
                    if (s.IndexOf("DataBase") != 0)
                    {
                        Database = s.Substring(s.IndexOf(" \""), s.IndexOf("\" "));
                    }
                    if (s.IndexOf("Address") != 0)
                    {
                        Address = s.Substring(s.IndexOf(" \""), s.IndexOf("\" "));
                    }
                    if (s.IndexOf("User") != 0)
                    {
                        User = s.Substring(s.IndexOf(" \""), s.IndexOf("\" "));
                    }
                    if (s.IndexOf("Password") != 0)
                    {
                        Password = s.Substring(s.IndexOf(" \""), s.IndexOf("\" "));
                    }

                } while (s != null);
                streamReader.Close();
            }
            else
            {
                Debug.WriteLine("Error reading configuration file");
            }
            sql = new ManagerSQL(Address, Database, User, Password);
            sql.connect();
        }

        public ManagerSQL getManagerSQL()
        {
            return sql;
        }


    }
}
