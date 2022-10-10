using AulaEF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CF.Context
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
