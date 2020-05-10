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
        private ColumnHeader ComImage;
        private ColumnHeader ComName;
        private ColumnHeader ComDescription;
        private ColumnHeader ComPrice;
        private ColumnHeader comNumber;

        public ListProductsView(ListView list)
        {
            ModelProducts.Instance();
            listView = list;
            comNumber = new ColumnHeader();
            ComImage = new ColumnHeader();
            ComName = new ColumnHeader();
            ComDescription = new ColumnHeader();
            ComPrice = new ColumnHeader();
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            comNumber,
            ComImage,
            ComName,
            ComDescription,
            ComPrice});
 
            comNumber.Text = "Nr.";
            comNumber.TextAlign = HorizontalAlignment.Center;
            comNumber.Width = 50;

            ComImage.Text = "     Obraz    ";
            ComImage.TextAlign = HorizontalAlignment.Center;

            ComName.Text = "Nazwa";
            ComName.TextAlign = HorizontalAlignment.Center;
         
 
            ComDescription.Text = "Opis";
            ComDescription.TextAlign = HorizontalAlignment.Center;
           
            ComPrice.Text = "Cena";
            ComPrice.TextAlign = HorizontalAlignment.Center;
          

        }
        public void add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
        
            ListViewItem item = new ListViewItem(listView.Items.Count.ToString());
            item.Checked = true;
            ImageList imageList = new ImageList();
            if (product.getImage() != "")
            {
                imageList.Images.Add(new Icon(product.getImage()));
                listView.SmallImageList = imageList;
                
                item.StateImageIndex = 1;
            }
            else
            {
                item.SubItems.Add(product.getImage());
            }
            item.SubItems.Add(product.getName());
            item.SubItems.Add(product.getDescription());
            item.SubItems.Add(product.getPrice());
            listView.Items.Add(item);
            ModelProducts.Instance().addProduct(product);
        }
        public void reSize(int width)
        {
            width -= 50;
            ComDescription.Width = width / 4;
            ComName.Width = width / 4;
            ComImage.Width = width / 3;
            ComPrice.Width = width / 7;
        }
    }
}
