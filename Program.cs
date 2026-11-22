using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }

    static void PrintBookTitle(string title) 
    {
        Console.WriteLine($"Book Title: {title}.");
    }

    static void AddBonusPages(int pages)
    {
        pages+= 50;
    }
    static void AddBonusPages(ref int pages)
    {
        pages+= 50;
    }

    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }

    static void ReplaceArray(ref double[] prices)
    {
        double[] newArray = { 10.0, 12.5, 15.0 };
        prices = newArray;
    }
    static bool TryGetPrice(string title, out double price)
    {
        if (title == "Clean Code")
        {
            price = 25.5;
            return true;
        }else
        {
            price = 0;
            return false;
        }
    }
    public static void Main()
    {
        #region Question 1

        //1.Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
        //the second price(index 1).
        double[] prices = { 25.5 , 40.0 , 33.75};
        Console.WriteLine(prices[1]);
        #endregion

        #region Question 2

        //2.Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
        //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0

        int[,] shelfCopies = { {3,5 } , {1,4 } };
        Console.WriteLine(shelfCopies[1,0]);

        #endregion

        #region Question 3

        //3.Write a method called PrintWelcomeMessage that takes no parameters and prints
        //"Welcome to the Library!".Call it from Main.
        PrintWelcomeMessage();
        #endregion

        #region Question 4

        //4.Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
        //"Clean Code".
        PrintBookTitle("Clean Code");
        #endregion

        #region Question 5

        //5.Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
        //int pages = 400; and print pages afterward. What do you expect to see, and why?

        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages); //400 because what happend in the function does not affect outside the function
        #endregion

        #region Question 6
        //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
        //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to 
        //see, and why?

        double[] prices02 = { 25.5, 40.0 };
        ApplyDiscount(prices02);
        Console.WriteLine(prices02[0]); // 20.5 because arrays are reference types

        #endregion

        #region Question 7
        // 7. Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
        //Call it and print pages afterward. How is the result different from question 5 ?
        pages = 400;
        AddBonusPages(ref pages);
        Console.WriteLine(pages); // 450 because ref passes the original variable by reference.

        #endregion

        #region Question 8
        // 8.Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
        //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
        //afterward.
        double[] prices03 = { 99.6 , 78.1 ,55.2 , 40.0 };
        ReplaceArray( ref prices03);
        Console.WriteLine(prices03.Length); //3

        #endregion

        #region Question 9
        // 9.Write a method bool TryGetPrice(string title, out double price) that returns true and sets
        //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
        //and print the price if found

        string title = "Clean Code";
        bool isThere = TryGetPrice(title, out double price);
        if (isThere)
            Console.WriteLine(price);
        else
            Console.WriteLine("Not Found");
        #endregion



    }
}