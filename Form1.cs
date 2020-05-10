using SampleApplication.Controller;
using SampleApplication.Model;
using SampleApplication.SQL;
using SampleApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            
            this.manager = new Manager("A:\\Project\\Wlasne\\SampleApplication\\Config.txt");

            client = new Client();
            InitializeComponent();
            ControllerProduct.Instance().RegisterView(this);
            this.listProductsView = new ListProductsView(LV_Main);
            this.productView = new ProductView(LV_Option);
            this.timer.Start();

        }
        public void ModelChange(object sender, ModelChangeEventArgs e)
        {

            
            Product product = manager.getManagerSQL().GetSqlTableProducts().getProduct(e.Number);
            if (product != null)
            {
                listProductsView.add(product);
                productView.add(product);
            }
        }
        private void LV_Main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int temp = (int)(this.Width/3.325f);
            productView.reSize(temp);
            listProductsView.reSize(this.Width - temp - 30);
        }
    }
}
