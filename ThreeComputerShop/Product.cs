using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeComputerShop
{
    public class Product
    {
        public string name;
        public string charact;
        public string descr;
        public double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Charact
        {
            get { return charact; }
            set { charact = value; }
        }

        public string Descr
        {
            get { return descr; }
            set { descr = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                    throw new System.Exception("Цена должна быть больше 0!");
                price = value;
            }
        }

        public Product()
        {
            Name = "unknown";
            Charact = "unknown";
            Descr = "unknown";
            Price = 0;
        }
        public Product(string name, string charact, string descr, int price)
        {
            Name = name;
            Charact = charact;
            Descr = descr;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Charact}, {Descr}, {Price.ToString()}";
        }
    }
}
