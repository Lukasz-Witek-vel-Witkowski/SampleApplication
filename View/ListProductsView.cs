using SampleApplication.Model;
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
            ModelProducts.Instance();
            listView = list;
        }
        public void add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            ListViewItem item = new ListViewItem(listView.Items.Count.ToString());
            item.Checked = true;
            item.SubItems.Add(product.getImage());
            item.SubItems.Add(product.getName());
            item.SubItems.Add(product.getDescription());
            item.SubItems.Add(product.getPrice());
            listView.Items.Add(item);
            ModelProducts.Instance().addProduct(product);
        }
    }
}
