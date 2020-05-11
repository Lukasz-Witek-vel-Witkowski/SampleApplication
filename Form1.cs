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
        private bool active = true;
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

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int temp = (int)(this.Width / 3.325f);
            productView.reSize(temp);
            listProductsView.reSize(this.Width - temp - 30);
        }

        private void bt_Other_products_Click(object sender, EventArgs e)
        {
            active = false;
            FormInputNumber formInputNumber = new FormInputNumber();
            formInputNumber.setManager(this.manager);
            formInputNumber.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (manager.getNumber() == "OK")
            {
                manager.setNumber("");
                manager.setSize("");
                listProductsView.Clear();
                productView.Clear();
                active = true;
            }
            else if (manager.getNumber() != "" && manager.getSize() != "")
            {
                int size = int.Parse(manager.getSize());
                for (int i = 0; i < size; i++)
                    ControllerProduct.Instance().RaiseModelChange(this, new ModelChangeEventArgs(int.Parse(manager.getNumber())));

                manager.setNumber("");
                manager.setSize("");
                active = true;
            }
            else if (manager.getNumber() != "")
            {
                ControllerProduct.Instance().RaiseModelChange(this, new ModelChangeEventArgs(int.Parse(manager.getNumber())));
                manager.setNumber("");
                active = true;
            }
        }

        private void timer_Trick(object sender, EventArgs e)
        {
            if (this.active)
            {
                timer.Stop();
                ControllerProduct.Instance().RaiseModelChange(this, new ModelChangeEventArgs(client.getNext()));
                timer.Start();
            }
            else
            {
                timer.Start();
            }
        }

        private void bt_Add_quantity_Click(object sender, EventArgs e)
        {
            active = false;
            FormMoreProduct formMoreProduct = new FormMoreProduct();
            formMoreProduct.setManager(this.manager);
            formMoreProduct.Show();
        }


        private void bt_buy_Click(object sender, EventArgs e)
        {
            active = false;
            FormFinish formFinish = new FormFinish();
            manager.setSize(ModelBasket.Instance().getSum().ToString());
            manager.setNumber("1");
            formFinish.setManger(this.manager);
            formFinish.Show();
        }



        private void bt_help_Click(object sender, EventArgs e)
        {
            active = false;
            MessageBox.Show("Poczekaj na pomoc", "Wezwanie pomocy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            active = true;
        }
    }
}
