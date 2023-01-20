using Tubes_Pet_Shop.Controller;
using Tubes_Pet_Shop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Pet_Shop.Model
{
    internal class M_Product
    {
        string id, qty, total;

        public M_Product()
        {
        }

        public M_Product(string id, string qty, string total)
        {
            this.Id = id;
            this.Qty = qty;
            this.Total = total;
        }

        public string Id { get => id; set => id = value; }
        public string Qty { get => qty; set => qty = value; }
        public string Total { get => total; set => total = value; }
    }
}
