using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            int breadQty, pastryQty, totalCost;
            Cart yourCart = new Cart();
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread is $5 for one loaf and pastries are $2 each");
            Console.WriteLine("Special #1- Buy two loaves and get the third free!");
            Console.WriteLine("Special #2- Buy three pastries for $5!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please enter how many loaves you'd like to purchase");
            breadQty = int.Parse(Console.ReadLine());
            yourCart.BreadQty(breadQty);
            Console.WriteLine("Please enter how many pastries you'd like to buy");
            pastryQty = int.Parse(Console.ReadLine());
            yourCart.PastryQty(pastryQty);
            totalCost = cart.CalculateTotal();
            Console.WriteLine("Your total is ${0}!", totalCost);
        }
    }
}