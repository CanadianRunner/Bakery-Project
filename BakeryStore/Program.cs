using System;
using BakeryStore.Models;

namespace BakeryStore
{
  public class Program
  {
    public static void Main()
    {
      string title = @"
 _       __     __                             __           ____  _                    _          ____        __                   __
| |     / /__  / /________  ____ ___  ___     / /_____     / __ \(_)__  _____________ ( )_____   / __ )____ _/ /_____  _______  __/ /
| | /| / / _ \/ / ___/ __ \/ __ `__ \/ _ \   / __/ __ \   / /_/ / / _ \/ ___/ ___/ _ \|// ___/  / __  / __ `/ //_/ _ \/ ___/ / / / / 
| |/ |/ /  __/ / /__/ /_/ / / / / / /  __/  / /_/ /_/ /  / ____/ /  __/ /  / /  /  __/ (__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ /_/  
|__/|__/\___/_/\___/\____/_/ /_/ /_/\___/   \__/\____/  /_/   /_/\___/_/  /_/   \___/ /____/  /_____/\__,_/_/|_|\___/_/   \__, (_)   
                                                                                                                         /____/      
";
      string singleBreadPrice = "One bread loaf = $5.";
      string singlePastryPrice = "One Pastry = $2.";
      string userInputStart = "Please press a key to continue and see available offers.";
      string breadDeal = "buy two get one free!";
      string pastryDeal = "One Pastry for $2. Or 3 pastries for $5!";
      string couponCode = "PIERRESBAKERYCOUPON1234";

      Console.WriteLine(title);
      Console.WriteLine("We're excited for you try our delicious Breads and Pastries!");
      Console.WriteLine($"Our fresh out the oven bread can be had at: {singleBreadPrice}");
      Console.WriteLine($"Our freshly baked pastries can be had for: {singlePastryPrice}");
      Console.WriteLine(userInputStart);
        
      Console.ReadKey();
      Console.Clear();
      Console.WriteLine("Before I take your order; I would like to make you aware of our current promotions.");
      Console.WriteLine($"Today I can offer our bread at : {breadDeal}");
      Console.WriteLine($"I can also offer our pastries at even greater discount: {pastryDeal}");
      Console.WriteLine();

      Console.WriteLine("Please enter how many loafs of bread you would like to order today?");
      string breadOrder = Console.ReadLine();
      int BreadQuantity = int.Parse(breadOrder);
      Bread customerBreadOrder = new Bread(BreadQuantity);
      customerBreadOrder.CalculateTotalCost();

      Console.WriteLine("Please enter how many pastries you would like?");
      string pastryOrder = Console.ReadLine();
      int Quantity = int.Parse(pastryOrder);
      Pastry customerPastryOrder = new Pastry(Quantity);
      customerPastryOrder.CalculateTotalCost();
      Console.Clear();

      ShoppingCart CombinedShoppingCart = new ShoppingCart();
      CombinedShoppingCart.CalculateTotalCost(customerBreadOrder.TotalCost, customerPastryOrder.TotalCost);
      int finalCalculation = CombinedShoppingCart.TotalCost;
      Console.WriteLine($"Your total comes to: $ {finalCalculation}");
      Console.WriteLine($"Come again! As a gesture of our gratitude, please accept this coupon for 25% off your next order.");
      Console.WriteLine();
      Console.WriteLine($"Coupon code: {couponCode}");
    }
  }
}

