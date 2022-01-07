using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_14._1
{
    public enum Сategorys
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string PpoductImage { get; set; }
        public Сategorys Category { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }

}
