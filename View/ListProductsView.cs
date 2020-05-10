using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication.View
{
    partial class ListProductsView
    {
        private ListView listView;
        public ListProductsView(ListView list)
        {
            listView = list;
        }
        public void add(Product product)
        {
            ListViewItem item = new ListViewItem();
            item.Checked = true;
            item.SubItems.Add(listView.Size.ToString());
            item.SubItems.Add(product.getImage());
            item.SubItems.Add(product.getName());
            item.SubItems.Add(product.getDescription());
            item.SubItems.Add(product.getPrice().ToString());
            listView.Items.Add(item);
        }
    }
}
