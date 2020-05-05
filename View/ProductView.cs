using System;
using System.Collections.Generic;
using System.Linq;
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
            listView.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.CheckBoxes = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            ListViewItem item = new ListViewItem("iteam", 0);
            item.Checked = true;
            listView.Items.Add(item);
        }


    }
}
