namespace P06SalesTerminal.Models
{
  using System.Collections.Generic;

  public class Terminal
  {
    private Sale _currentSale;
    public Terminal(string name)
    {
      Name = name;
      Sales = new List<Sale>();
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public List<Sale> Sales { get; set; }

    public Sale NewSale() {
     var sale = new Sale();

     Sales.Add(sale);

     _currentSale = sale;

     return sale;
    }

    public SaleLineItem AddItem(Product product, int quantity) {
     return _currentSale.AddItem(product, quantity);
    }
  }
}