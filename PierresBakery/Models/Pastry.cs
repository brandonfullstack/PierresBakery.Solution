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
            double pastryPrice = this.Quantity * 2;

            if (this.Quantity % 4 == 0)
            {
                pastryPrice -= 2;
            }

            return pastryPrice;
        }
  }
}