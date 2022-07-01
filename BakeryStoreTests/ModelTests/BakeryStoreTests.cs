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
      Bread newBread = newBread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}