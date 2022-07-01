using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStore.Models;

namespace BakeryStore.TestTools
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadClass_SetsQuantity_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(3, newBread.Quantity);
    }

    [TestMethod]
    public void BreadClass_CalculatesTotalCostUsingDeals_Int()
    {
      Bread newBread = new Bread(3);
      newBread.CalculateTotalCost();
      Assert.AreEqual(10, newBread.TotalCost);
    }

    [TestMethod]
    public void BreadClass_CalculatesTotalCostWithOutDeals_Int()
    {
      Bread newBread = new Bread(1);
      newBread.CalculateTotalCost();
      Assert.AreEqual(5, newBread.TotalCost);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryClass_SetsQuantity_Int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(3, newPastry.Quantity);
    }

    [TestMethod]
    public void PastryClass_CalculatesTotalCostUsingDeals_Int()
    {
      Pastry newPastry = new Pastry(4);
      newPastry.CalculateTotalCost();
      Assert.AreEqual(7, newPastry.TotalCost);
    }
  }
}