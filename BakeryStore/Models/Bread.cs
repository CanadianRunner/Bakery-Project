using System;

namespace BakeryStore.Models
{
  public class Bread
  {
    public int TotalCost { get; private set; }
    public int Quantity { get; private set; }

    public Bread(int quantity, int totalCost = 0)
    {
      TotalCost = totalCost;
      Quantity = quantity;
    }

    public int CalculateTotalCost()
    {
      if(Quantity > 2)
      {
        int remainder = Quantity % 3;
        int priceOfDeal = (((Quantity - remainder) /3) * 10);
        int priceOfRemaining = remainder *5;
        TotalCost = priceOfDeal + priceOfRemaining;
        return TotalCost;
      } else {
        
      }
    }
  }
}