using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using P06SalesTerminal.Context;
using P06SalesTerminal.Models;

namespace P06SalesTerminal
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            var store = new Store("My Shop");

            var cola = store.AddProduct("Cola", 2.2m);
            var chips = store.AddProduct("Chips", 1.0m);
            var chocolate = store.AddProduct("Chocolate", 1.5m);
            var bread = store.AddProduct("Bread", 1.2m);
            var ice_cream = store.AddProduct("Ice Cram", 2.7m);
            
            store.AddProduct("Chocolate Ice Cream", 2.9m);

            var chocolate_ice_cream = store.GetProduct("Chocolate Ice Cream");

            var t1 = store.AddTerminal("Terminal 1");
            var t2 = store.AddTerminal("Terminal 2");

            t1.NewSale();
            t1.AddItem(cola, 3);

            // sale1.AddItem()


            var sale2 = t2.NewSale();

            // var context = new DbMsContext();
            // context.Stores.Add(store);
            // context.SaveChanges();

            // var context = new DbPgContext();
            // context.Stores.Add(store);
            // context.SaveChanges();

            var context = new DbMsContext();
            var ss = context
              .Stores
              .Include(s=>s.Products)
              .Include(s=>s.Terminals)
              .FirstOrDefault(s=>s.Id == 1);
            
            var terminal = ss.GetTerminal("Terminal 1");
            
            terminal.NewSale();
            terminal.AddItem(ice_cream, 1);
            terminal.AddItem(chips, 3);

            context.SaveChanges();

        }
    }
}
