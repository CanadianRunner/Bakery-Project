using System;

namespace BakeryStore.Models
{
  public class Pastry
  {
    public int TotalCost { get; private set; }
    public int Quantity { get; private set; }

    public Pastry(int quantity, int totalCost = 0)
    {
      TotalCost = totalCost;
      Quantity = quantity;
    }

    // public int CalculateTotalCost()
    // {

    // }
  }
}