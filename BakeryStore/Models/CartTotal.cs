using System;

namespace BakeryStore.Models
{
  public class shoppingCart
  {
    public int TotalCost { get; private set; }

    public ShoppingCart( int totalCost = 0 )
    {
      TotalCost = totalCost;
    }

    public int CalculateFinalCost(int breadCost, int pastryCost)
    {
      TotalCost = breadCost + pastryCost;
      return TotalCost;
    }
  }
}