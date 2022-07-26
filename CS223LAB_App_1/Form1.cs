using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            if (Convert.ToDouble(txt_price.Text) <= 0)
            { 
                 
                priceerror.SetError(txt_price, "must be greater than zero");

            } 
            else if (Convert.ToInt32(txt_quant.Text) <= 0)
            {
                if (String.IsNullOrEmpty(txt_price.Text))
                {
                   priceerror.SetError(txt_quant, "quantity is needed");
                }
                else{
                    priceerror.SetError(txt_quant, "must be greater than zero");
                }
            }
            else
            {
                priceerror.Clear();
                r.price = Convert.ToDouble(txt_price.Text);
                r.name = txt_name.Text;
                r.quantity = Convert.ToInt32(txt_quant.Text);
                r.sku_num = Convert.ToInt32(txt_sku.Text);
                r.num = Convert.ToInt32(txt_number.Text);
                r.date = dtp.Text;

                r.Save();
                dataview1.DataSource = null;
                dataview1.DataSource = Register.Getproducts();
                MessageBox.Show(r.name + " is added to database");
            }
            
        }

        private void txt_display_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Register.Getproducts());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_sku_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
