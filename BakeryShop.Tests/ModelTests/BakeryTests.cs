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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    

  }
}