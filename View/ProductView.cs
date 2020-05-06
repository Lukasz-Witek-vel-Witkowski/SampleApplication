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

     
          /*  listView.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listView.View = System.Windows.Forms.View.Details;
            listView.LabelEdit = false;
            listView.AllowColumnReorder = false;
            listView.CheckBoxes = false;
            listView.FullRowSelect = true;
            listView.GridLines = false;

            ListViewItem item = new ListViewItem("iteam", 0);
            item.Checked = true;
            listView.Items.Add(item);*/
        }
        public void ModelChange(object sander, ModelChangeEventArgs e)
        {

        }

    }
}
