using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    
    public Bread(int breadQuantity)
    {
      this.Quantity = breadQuantity;
    }
    
    public decimal GetBreadPrice()
    {
      // Buy 2, get 1 free logic
      int freeLoaves = this.Quantity / 3;
      int paidLoaves = this.Quantity - freeLoaves;

      return paidLoaves * 5;
    }
  }
}