using AulaEF_CF.Context;
using AulaEF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                #region INSERE DADOS
                context.Persons.Add(new Person() { Name = "Felipe", Phone = "123" });

                Person p = new Person();

                p.Name = "Baratao";
                p.Mail = "baratox@raid.com.br";
                p.Phone = "321";
                p.Mobile = "999";

                context.Persons.Add(p);
                context.SaveChanges();
                #endregion
                #region LISTA TODOS
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }
                #endregion
                #region LISTA UNICO
                string n = Console.ReadLine();
                //Person xpto = new PersonContext().Persons.Find(args[0]);
                Person find = new PersonContext().Persons.FirstOrDefault(f => f.Name == n);
                if (find != null)
                    Console.WriteLine(find.ToString());
                else
                    Console.WriteLine("Registro não encontrado");
                #endregion
                #region REMOVE
                context.Entry(find).State = EntityState.Deleted;
                context.Persons.Remove(find);
                context.SaveChanges();
                #endregion

                Console.ReadKey();
            }

        }
    }
}
