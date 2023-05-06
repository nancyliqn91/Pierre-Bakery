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

}