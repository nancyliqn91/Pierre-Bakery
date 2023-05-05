using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryShop.Models;
using System;

namespace BakeryShop.Tests
{ 
  [TestClass]
  public class BakeryTests
  {
    // Test methods go here
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void BreadOrder_ReturnLessThan3_Int()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(10, newBread.BreadOrder());
    }

    [TestMethod]
    public void BreadOrder_ReturnMoreThan3_Int()
    {
      Bread newBread = new Bread(7);
      Assert.AreEqual(25, newBread.BreadOrder());
    }

  }
}