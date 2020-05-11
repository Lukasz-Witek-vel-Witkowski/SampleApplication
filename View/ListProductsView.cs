using SampleApplication.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private ImageList imageList;

        public ListProductsView(ListView list)
        {
            ModelProducts.Instance();
            listView = list;
            comNumber = new ColumnHeader();
            ComImage = new ColumnHeader();
            ComName = new ColumnHeader();
            ComDescription = new ColumnHeader();
            ComPrice = new ColumnHeader();
            imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50);
            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            comNumber,
            ComImage,
            ComName,
            ComDescription,
            ComPrice});

            comNumber.Text = "Obraz";
            comNumber.TextAlign = HorizontalAlignment.Center;
            comNumber.Width = 75;

            ComImage.Text = "Nr.";
            ComImage.TextAlign = HorizontalAlignment.Center;
            comNumber.Width = 50;

            ComName.Text = "Nazwa";
            ComName.TextAlign = HorizontalAlignment.Center;


            ComDescription.Text = "Opis";
            ComDescription.TextAlign = HorizontalAlignment.Center;

            ComPrice.Text = "Cena";
            ComPrice.TextAlign = HorizontalAlignment.Center;
            comNumber.Width = 50;

            listView.SmallImageList = imageList;
        }
        public void add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }

            ListViewItem item = new ListViewItem("");
            item.SubItems.Add(listView.Items.Count.ToString());
            if (product.getImage() != "")
            {
                imageList.Images.Add(Image.FromFile(product.getImage()));
                item.ImageIndex = imageList.Images.Count - 1;

            }
            item.SubItems.Add(product.getName());
            item.SubItems.Add(product.getDescription());
            item.SubItems.Add(product.getPrice());
            listView.Items.Add(item);
            ModelProducts.Instance().addProduct(product);
        }

        internal void Clear()
        {
            ModelProducts.Instance().Clear();
            listView.Items.Clear();
            imageList.Images.Clear();
        }

        public void reSize(int width)
        {
            width -= 200;
            ComDescription.Width = width / 2;
            ComName.Width = width / 2;
        }
    }
}
