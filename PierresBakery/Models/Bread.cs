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
        double breadPrice = this.Quantity * 5;
        
        if (this.Quantity % 3 == 0)
         {
           breadPrice -= 5;
         }

          return breadPrice;

    }
  }
}