using System;

namespace BakeryStore.Models
{
  public class ShoppingCart
  {
    public int TotalCost { get; private set; }

    public ShoppingCart( int totalCost = 0 )
    {
      TotalCost = totalCost;
    }

    public int CalculateTotalCost(int breadCost, int pastryCost)
    {
      TotalCost = breadCost + pastryCost;
      return TotalCost;
    }
  }
}