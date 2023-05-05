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
    Console.WriteLine($"Bread: {newBread.Quantity}");
    Console.WriteLine($"Pastry: {newPastry.Quantity}");
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

      newBread.Quantity = loaves;
      newPastry.Quantity = pNum;
      ConfirmOrEditOrder(newBread, newPastry);   
    }
  }
 
  static void CheckOut(Bread newBread, Pastry newPastry)
  {
    int breadCost = newBread.BakeryOrder();
    int pastryCost = newPastry.BakeryOrder();
    int order = breadCost + pastryCost;
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Your bread order is ${breadCost}, your pastry order is ${pastryCost}. Your total cost is ${order}.");
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