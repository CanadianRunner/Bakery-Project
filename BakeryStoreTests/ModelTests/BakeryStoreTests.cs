using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStore.Models;

namespace BakeryStore.TestTools
{
  [TestClass]
  public class BreadTests
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
  }
}