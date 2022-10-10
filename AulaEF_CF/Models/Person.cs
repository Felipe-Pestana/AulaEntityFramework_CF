using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CF.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Mobile { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}\nNome: {this.Name}" +
                $"\nTelefone: {this.Phone}" +
                $"\nCelular: {this.Mobile}" +
                $"\nEmail: {this.Mail}\n\n";
        }
    }
}
