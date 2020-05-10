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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            this.manager = new Manager("A:\\Project\\Wlasne\\SampleApplication\\Config.txt");
            client = new Client();
            InitializeComponent();
            ModelProduct.Instance();
            ModelProducts.Instance();
            this.listProductsView = new ListProductsView(LV_Main);
            this.productView = new ProductView(LV_Option);
            this.timer.Start();

        }

        private void LV_Main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setNumber(int number)
        {
            try
            {
                listProductsView.add(manager.getManagerSQL().GetSqlTableProducts().getProduct(number));
            }
            catch (ArgumentNullException)
            {
                Debug.WriteLine("Database element error");
            }
        }
    }
}
