using System;
using System.Collections.Generic;
using System.Linq;
using P06SalesTerminal.Models;

public class Sale
{
  public Sale()
  {
    Time = new DateTime();
    Items = new List<SaleLineItem>();
  }

  public int Id { get; set; }

  public DateTime Time { get; set; }

  public List<SaleLineItem> Items { get; set; }

  public SaleLineItem AddItem(Product product, int quantity)
  {
    var sli = new SaleLineItem(this, product, quantity);

    Items.Add(sli);

    return sli;
  }

  public decimal Total
  {
    get
    {
      return Items.Sum(p => p.Total);
    }
  }
}