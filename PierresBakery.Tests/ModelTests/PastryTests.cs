using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void TestPastryPrice1Pastry()
    {
    // Arrange
    Pastry pastry = new Pastry(1);

    // Act
    double price = pastry.GetPastryPrice();

    // Assert
    Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void TestPastryPrice5Pastry()
    {
    // Arrange
    Pastry pastry = new Pastry(5);

    // Act
    double price = pastry.GetPastryPrice();

    // Assert
    Assert.AreEqual(8, price);
    }
  }
}