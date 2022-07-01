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

    public int CalculateTotalCost()
    {
      if(Quantity > 2)
      {
        int remainder = Quantity % 3;
        TotalCost = (((Quantity - remainder) / 3) * 5) + (remainder * 2);
        return TotalCost;
      } else {
        TotalCost = Quantity * 2;
        return TotalCost;
      }
    }
  }
}