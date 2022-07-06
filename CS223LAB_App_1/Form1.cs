using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223LAB_App_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.price = Convert.ToDouble(txt_price.Text);
            r.name = txt_name.Text;
            r.quantity= Convert.ToInt32(txt_quant.Text);
            r.sku_num = Convert.ToInt32(txt_sku.Text);
            r.num = Convert.ToInt32(txt_number.Text);
            r.date = dtp.Text;
            Console.WriteLine(" SAVED");
            MessageBox.Show(r.name + " is added to database");
            
        }
    }
}
