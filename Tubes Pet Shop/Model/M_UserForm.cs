using Tubes_Pet_Shop.Controller;
using Tubes_Pet_Shop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Pet_Shop.Model
{
    internal class M_UserForm
    {
        string name, address, phone, role;
        public M_UserForm()
        {

        }

        public M_UserForm(string name, string address, string phone, string role)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Role = role;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Role { get => role; set => role = value; }
    }
}
