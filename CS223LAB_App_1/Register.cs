using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS223LAB_App_1
{
    public class Register
    {
        static List<Register> list = new List<Register>();
        public int num { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string date { get; set; }
        public int sku_num { get; set; }
        public bool availability { get; set; }
        public void Save()
        {
            list.Add(this);
        }
       static  public List<Register>Getproducts()
        {
            return list;    
        }
    }
}
