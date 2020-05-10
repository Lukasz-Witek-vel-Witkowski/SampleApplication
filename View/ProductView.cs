using SampleApplication.Controller;
using SampleApplication.Model;
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
        private ListViewItem.ListViewSubItem ValueName;
        private ListViewItem.ListViewSubItem ValuePrice;
        private ListViewItem.ListViewSubItem ValueSum;
        private ColumnHeader com1;
        private ColumnHeader com2;

        public ProductView(ListView list)
        {
            listView = list;
            CreativeListView();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void CreativeListView()
        {
            this.com1 = new ColumnHeader();
            this.com2 = new ColumnHeader();

            this.com1.Text = "Właściwości";
            this.com1.Width = 240;

            this.com2.Text = "Wartość";
            this.com2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.com2.Width = 300;

            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.com1,
            this.com2});

            ListViewGroup listViewGroup1 = new ListViewGroup("Produkt", HorizontalAlignment.Center);
            ListViewGroup listViewGroup2 = new ListViewGroup("Koszyk", HorizontalAlignment.Center);

            ValueName = new ListViewItem.ListViewSubItem(null, " ", Color.DarkGreen, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))));
            ValuePrice = new ListViewItem.ListViewSubItem(null, " ", Color.DarkGreen, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))));
            ValueSum = new ListViewItem.ListViewSubItem(null, "0.0", Color.Brown, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238))));
            
            ListViewItem listViewItem1 = new ListViewItem(new ListViewItem.ListViewSubItem[] {
            new ListViewItem.ListViewSubItem(null, "Nazwa:", Color.DarkGreen, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)))),
                ValueName}, -1);
            ListViewItem listViewItem2 = new ListViewItem(new ListViewItem.ListViewSubItem[] {
            new ListViewItem.ListViewSubItem(null, "Cena: ", Color.DarkGreen, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)))),
                ValuePrice}, -1);
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] {
            new ListViewItem.ListViewSubItem(null, "Do zapłaty: ", Color.Brown, SystemColors.Window, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)))),
                ValueSum}, -1);
            
            listViewGroup1.Header = "Produkt";
            listViewGroup1.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup1.Name = "groupProduct";
            listViewGroup2.Header = "Koszyk";
            listViewGroup2.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup2.Name = "groupBasket";
            
            listView.Groups.AddRange(new ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
           
            listView.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            
            listView.Items.AddRange(new ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
        }

        public void add(Product product)
        {
            ModelBasket.Instance().setProduct(product);
            ValueName.Text = product.getName();
            ValuePrice.Text = product.getPrice();
            ValueSum.Text = ModelBasket.Instance().getSum().ToString();
        }

        public void reSize(int width)
        {
            width -= 10;
            com1.Width = width / 2;
            com2.Width = width / 2;
        }

    }
}
