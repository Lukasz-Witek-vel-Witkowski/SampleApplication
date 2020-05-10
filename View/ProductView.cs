using SampleApplication.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication.View
{
    class ProductView
    {
        private ListView listView;

        public ProductView(ListView list)
        {
            listView = list;

        }
        public void add(Product product)
        {
              ListViewItem item = new ListViewItem("iteam", 0);
              item.Checked = true;
              listView.Items.Add(item);
        }
        public void ModelChange(object sander, ModelChangeEventArgs e)
        {

        }

    }
}
