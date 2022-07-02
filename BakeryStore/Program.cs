using System;
using BakeryStore.Models;

namespace BakeryStore
{
  public class Program
  {
    public static void Main()
    {
      // Console.WriteLine(Ascii.title);
      // Console.Read();
      string title = @"
 _       __     __                             __           ____  _                    _          ____        __                   __
| |     / /__  / /________  ____ ___  ___     / /_____     / __ \(_)__  _____________ ( )_____   / __ )____ _/ /_____  _______  __/ /
| | /| / / _ \/ / ___/ __ \/ __ `__ \/ _ \   / __/ __ \   / /_/ / / _ \/ ___/ ___/ _ \|// ___/  / __  / __ `/ //_/ _ \/ ___/ / / / / 
| |/ |/ /  __/ / /__/ /_/ / / / / / /  __/  / /_/ /_/ /  / ____/ /  __/ /  / /  /  __/ (__  )  / /_/ / /_/ / ,< /  __/ /  / /_/ /_/  
|__/|__/\___/_/\___/\____/_/ /_/ /_/\___/   \__/\____/  /_/   /_/\___/_/  /_/   \___/ /____/  /_____/\__,_/_/|_|\___/_/   \__, (_)   
                                                                                                                         /____/      
      ";
      string singleBreadPrice = "One bread loaf = $5";
      string singlePastryPrice = "One Pastry = $2";
      Console.WriteLine(title);
      Console.WriteLine("We're excited for you try our delicious Breads and Pastries!");
      Console.WriteLine($"Our prices are as follows: {singleBreadPrice}");
      Console.WriteLine($"Our freshly baked pastries can be had for: {singlePastryPrice}");
    }
  }
}