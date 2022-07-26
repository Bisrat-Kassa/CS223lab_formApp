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
            try
            {
                String.IsNullOrEmpty(txt_name.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                r.availability =is_checked.Checked ;

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

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
