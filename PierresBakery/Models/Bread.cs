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
    
    public double GetBreadPrice()
    {
        int freeLoaves = this.Quantity / 3;
        int paidLoaves = this.Quantity - freeLoaves;

        return paidLoaves * 5;
    }
  }
}