using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      this.Quantity = pastryQuantity;
    }

     public decimal GetPastryPrice()
    {
      // Buy 3, get 1 free logic
      int freePastries = this.Quantity / 4;
      int paidPastries = this.Quantity - freePastries;

      return paidPastries * 2;
    }
  }
}