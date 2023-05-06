using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryShop.Models;
using System;

namespace BakeryShop.Tests
{ 
  [TestClass]
  public class BakeryItemTests
  {
    [TestMethod]
    public void BakeryItemConstructor_CreateInstanceOfBakeryItem_BakeryItem()
    {
      BakeryItem newBakeryItem = new BakeryItem(2);
      Assert.AreEqual(typeof(BakeryItem), newBakeryItem.GetType());
    }

    [TestMethod]
    public void BakeryOrder_ReturnCost_Int()
    {
      BakeryItem newBakeryItem = new BakeryItem(5);
      Assert.AreEqual(20, newBakeryItem.BakeryOrder(5, 3));
    }
  }

  [TestClass]
  public class BreadTests
  {
    // for bread
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(7);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BakeryOrder_ReturnBreadCost_Int()
    {
      Bread newBread = new Bread(7);
      Assert.AreEqual(25, newBread.BakeryOrder());
    }
  }

  [TestClass]
  public class PastryTests
  {
    // for pastry
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry= new Pastry(7);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BakeryOrder_ReturnPastryCost_Int()
    {
      Pastry newPastry = new Pastry(8);
      Assert.AreEqual(12, newPastry.BakeryOrder());
    }
  }
  
}
