using System;
using BakeryShop.Models;

class Program
{
  static void Main()
  {
    // UI
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to the Pierre's Bakery!");
    Console.WriteLine("We have breads($5 per loaf), and pastry($2 for each). please enter the amount of breads you want.");
    string stringBread = Console.ReadLine();
    Console.WriteLine("Please enter the amount of pastry you want.");
    string stringPastry = Console.ReadLine();
    int loaves = int.Parse(stringBread);
    int pNum = int.Parse(stringPastry);
    Bread newBread = new Bread(loaves);
    Pastry newPastry = new Pastry(pNum);
    ConfirmOrEditOrder(newBread, newPastry);    
  }

  static void ConfirmOrEditOrder(Bread newBread, Pastry newPastry)
  {
    // code to confirm or edit order
    Console.WriteLine("Please confirm you entered your order correctly:");
    Console.WriteLine($"Bread: {newBread.Loaves}");
    Console.WriteLine($"Pastry: {newPastry.Loaves}");
    Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter your order.");

    string userInput = Console.ReadLine().ToLower();  
    if (userInput == "yes")
    {
      CheckOut(newBread, newPastry);
    }
    else
    {
      Console.WriteLine("Let's order again.Please enter the amount of breads you want.");
      string stringBread = Console.ReadLine();
      Console.WriteLine("Please enter the amount of pastry you want.");
      string stringPastry = Console.ReadLine();
      int loaves = int.Parse(stringBread);
      int pNum = int.Parse(stringPastry);

      newBread.Loaves = loaves;
      newPastry.Loaves = pNum;
      ConfirmOrEditOrder(newBread, newPastry);   
    }
  }
 
  static void CheckOut(Bread newBread, Pastry newPastry)
  {
    int breadMoney = newBread.BreadOrder();
    int pastryMoney = newPastry.PastryOrder();
    int order = breadMoney + pastryMoney;
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Your bread order is ${breadMoney}, your pastry order is ${pastryMoney}. Your total is ${order}.");
    Console.WriteLine("-----------------------------------------");

    // new order
    Console.WriteLine("Would you like to order Bakery (new)?");
    Console.WriteLine("Please enter 'new' to order new bakery. To exit, enter any key.");
    string userResponse = Console.ReadLine().ToLower(); 
    if (userResponse == "new")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Goodbye!");
    }

  }


}