using System;

namespace BakeryShop.Models
{
  public class BakeryItem
  {
    public int Quantity { get; set; }
    public BakeryItem(int num)
    {
      Quantity = num;
    }

    public int BakeryOrder(int unitPrice, int discountQuantity)
    {
      int cost = 0;
      if (Quantity > 0)
      {
        int regularPrice = Quantity * unitPrice;
        int discount = (int)(Math.Floor((double)(Quantity / discountQuantity))) * unitPrice;
        cost = regularPrice - discount;
        return cost;
      }
      return cost;
    }
  }

  public class Bread : BakeryItem
  {
    public Bread(int quantity) : base(quantity)
    {
    }

    public int BakeryOrder()
    {
      return BakeryOrder(5, 3);
    }
  }

  public class Pastry : BakeryItem
  {
    public Pastry(int quantity) : base(quantity)
    {
    }
    
    public int BakeryOrder()
    {
      return BakeryOrder(2, 4);
    }
  }
  // public class Pastry
  // {
  //   public int Loaves { get; set; }
  //   public Pastry(int pNum)
  //   {
  //      Loaves = pNum;
  //   }

  //   public int PastryOrder()
  //   {
  //     int pastryMoney = 0;
  //     if (1 <= Loaves && Loaves< 4)
  //     {
  //       pastryMoney = Loaves * 2;
  //       return pastryMoney;
  //     }
  //     if (Loaves >= 4)
  //     {
  //       pastryMoney = Loaves * 2 - (int)(Math.Floor((double)(Loaves / 4))) * 2;
  //       return pastryMoney;
  //     }
  //     return pastryMoney;
  //   }
  // }

}