namespace P06SalesTerminal.Models
{
  public class SaleLineItem
  {
    private SaleLineItem()
    {
        
    }
    
    public SaleLineItem(Sale sale, Product product, int quantity)
    {
        Sale = sale;
        Product = product;
        Quantity = quantity;
    }

    public int Id { get; set; }

    public Product Product { get; set; }

    public int Quantity { get; set; }
    
    public Sale Sale { get; set; }

    public decimal Total
    {
      get
      {
        return Product.Price * Quantity;
      }
    }
  }
}