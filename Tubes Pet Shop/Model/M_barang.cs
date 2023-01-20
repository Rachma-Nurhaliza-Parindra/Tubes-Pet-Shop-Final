using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Pet_Shop.Model
{
    internal class M_barang
    {
        string name, type, category, price;

        public M_barang()
        {

        }

        public M_barang(string name, string type, string category, string price)
        {
            this.Name = name;
            this.Type = type;
            this.Category = category;
            this.Price = price;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Category { get => category; set => category = value; }
        public string Price { get => price; set => price = value; }
    }
}
