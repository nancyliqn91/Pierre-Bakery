using System;

namespace BakeryShop.Models
{
  public class Bread
  {
    public int Loaves { get; set; }
    private int _breadMoney;

    public int BreadMoney
    {
      get { return _breadMoney; }
    }

    public Bread(int bNum)
    {
       Loaves = bNum;
    }

    public int BreadOrder()
    {
      int breadMoney = 0;
      if (1 <= Loaves && Loaves< 3)
      {
        breadMoney = Loaves * 5;
        return breadMoney;
      }

      if (Loaves >= 3)
      {
        breadMoney = Loaves * 5 - (int)(Math.Floor((double)(Loaves / 3))) * 5;
        return breadMoney;
      }

      return breadMoney;
    }
  }

  public class Pastry
  {
    public int PNumber { get; set; }
    private int _pastryMoney;

    public int PastryMoney
    {
      get { return _pastryMoney; }
    }

    public Pastry(int pNum)
    {
       PNumber = pNum;
    }


  }






}