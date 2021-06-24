namespace P06SalesTerminal.Models
{
  using System.Collections.Generic;
  using System.Linq;

  public class Store
  {
    public Store(string tradingName)
    {
      TradingName = tradingName;
      Terminals = new List<Terminal>();
      Products = new List<Product>();
    }

    public int Id { get; set; }

    public string TradingName { get; set; }

    public List<Terminal> Terminals { get; set; }

    public List<Product> Products { get; set; }

    public Product AddProduct(string name, decimal price)
    {
      var product = new Product(name, price);
      Products.Add(product);
      return product;
    }

    public Product GetProduct(string name) {
      return Products.FirstOrDefault(p=> p.Name == name);
    }
    public Terminal GetTerminal(string name) {
      return Terminals.FirstOrDefault(t=> t.Name == name);
    }
    public Terminal AddTerminal(string name)
    {
      var terminal = new Terminal(name);
      Terminals.Add(terminal);
      return terminal;
    }
  }
}