using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void TestBreadPrice1Loaf()
    {
      // Arrange
      Bread bread = new Bread(1);

      // Act
      decimal price = bread.GetBreadPrice();

      // Assert
      Assert.AreEqual(5, price);
    }
    
    [TestMethod]
    public void TestBreadPrice4Loaves()
    {
      // Arrange
      Bread bread = new Bread(4);

      // Act
      decimal price = bread.GetBreadPrice();

      // Assert
      Assert.AreEqual(15, price);
    }
  }
}