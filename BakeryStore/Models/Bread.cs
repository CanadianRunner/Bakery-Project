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
      //omitting quantity for good fail
    }
  }
}