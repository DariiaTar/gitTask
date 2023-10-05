
using System;

public class Shop {
    public static void Main() {
        int[] prices = {30, 50, 47, 89};
        string[] productNames = {"bread", "milk", "Chocolate", "Cheese"};
        
        for(int i = 0; i < 4; i++) {
           Console.WriteLine ("Product:" + productNames[i]);
           Console.WriteLine ("Price:" + prices[i] + "uah");
        }
        Console.ReadLine();
    }
    
    }
