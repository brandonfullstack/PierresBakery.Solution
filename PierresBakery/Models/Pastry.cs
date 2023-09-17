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

     public double GetPastryPrice()
        {
        int freePastries = this.Quantity / 4;
        int paidPastries = this.Quantity - freePastries;

        return paidPastries * 2;
        }
  }
}