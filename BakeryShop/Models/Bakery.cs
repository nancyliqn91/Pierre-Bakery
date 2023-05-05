using System;

namespace BakeryShop.Models
{
  public class BakeryItem
  {
    public int Quantity { get; set; }
    // public static int TotalQuantity { get; private set; } = 0;
    public BakeryItem(int num)
    {
      Quantity = num;
      // TotalQuantity += num;
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
    private static List<Bread> _instances = new List<Bread> {};
    public Bread(int quantity) : base(quantity)
    {
      _instance.Add(this);
    }

    public static List<Bread> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int BakeryOrder()
    {
      return BakeryOrder(5, 3);
    }
  }

  public class Pastry : BakeryItem
  {
    private static List<Pastry> _instances = new List<Pastry> {};
    public Pastry(int quantity) : base(quantity)
    {
      _instance.Add(this);
    }
    
    public static List<Pastry> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
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