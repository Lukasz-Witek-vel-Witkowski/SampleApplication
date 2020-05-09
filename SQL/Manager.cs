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
                int tempStart;
                int tempStop;
                do
                {
                    s = streamReader.ReadLine();
                    if (s != null)
                    {
                        tempStart = s.IndexOf(" \"");
                        tempStop = s.IndexOf("\" ");
                      
                        if (s.IndexOf("DataBase") != -1)
                            Database = s.Substring(tempStart+2, tempStop - tempStart-2);

                        else if (s.IndexOf("Address") != -1)
                            Address = s.Substring(tempStart+2, tempStop - tempStart-2);

                        else if (s.IndexOf("User") != -1)
                            User = s.Substring(tempStart+2, tempStop - tempStart-2);

                        else if (s.IndexOf("Password") != -1)
                            Password = s.Substring(tempStart+2, tempStop - tempStart-2);
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
            sql.querry("Select * from dbo.Products");
        }

        public ManagerSQL getManagerSQL()
        {
            return sql;
        }


    }
}
