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
      // 5, 3
      BakeryItem newBakeryItem = new BakeryItem(5);
      Assert.AreEqual(10, newBakeryItem.BakeryOrder(5, 3));
    }

    // [TestMethod]
    // public void PastryOrder_ReturnMoreThan4_Int()
    // {
    //   Pastry newPastry = new Pastry(8);
    //   Assert.AreEqual(12, newPastry.PastryOrder());
    // }
  }

  // [TestClass]
  // public class BakeryTests
  // {
  //   // for bread
  //   [TestMethod]
  //   public void BreadConstructor_CreateInstanceOfBread_Bread()
  //   {
  //     Bread newBread = new Bread(2);
  //     Assert.AreEqual(typeof(Bread), newBread.GetType());
  //   }
    
  //   [TestMethod]
  //   public void BreadOrder_ReturnLessThan3_Int()
  //   {
  //     Bread newBread = new Bread(2);
  //     Assert.AreEqual(10, newBread.BreadOrder());
  //   }

  //   [TestMethod]
  //   public void BreadOrder_ReturnMoreThan3_Int()
  //   {
  //     Bread newBread = new Bread(7);
  //     Assert.AreEqual(25, newBread.BreadOrder());
  //   }
  // }
  //   // for pastry
  // [TestClass]
  // public class PastryTests
  // {
  //   [TestMethod]
  //   public void PastryConstructor_CreateInstanceOfPastry_Pastry()
  //   {
  //     Pastry newPastry = new Pastry(2);
  //     Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  //   }

  //   [TestMethod]
  //   public void PastryOrder_ReturnLessThan4_Int()
  //   {
  //     Pastry newPastry = new Pastry(3);
  //     Assert.AreEqual(6, newPastry.PastryOrder());
  //   }

  //   [TestMethod]
  //   public void PastryOrder_ReturnMoreThan4_Int()
  //   {
  //     Pastry newPastry = new Pastry(8);
  //     Assert.AreEqual(12, newPastry.PastryOrder());
  //   }
  // }

}