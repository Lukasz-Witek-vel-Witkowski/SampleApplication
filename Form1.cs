using SampleApplication.Model;
using SampleApplication.SQL;
using SampleApplication.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
            this.manager = new Manager("Confing.txt");
            ModelProduct.Instance();
            ModelProducts.Instance();
            
        }
    }
}
