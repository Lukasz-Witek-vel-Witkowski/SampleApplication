using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class Client
    {
        private List<int> LData;
        private int iterator;
        public Client()
        {
            LData = new List<int>();
            loadData("A:\\Project\\Wlasne\\SampleApplication\\doc.txt");
        }
        void loadData(String path)
        {

            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                String s;
                s = streamReader.ReadLine();
                while (s != null)
                {
                    LData.Add(int.Parse(s));
                    s = streamReader.ReadLine();
                }
                streamReader.Close();
            }
        }

        public int getNext()
        {
            if(isNext())
            return LData[iterator++];

            return -1;
        }
        public bool isNext()
        {
            return !(iterator < LData.Count);
        }
    }
}
