// File: array_ex2.cs
// Write a program that, given an amount prints the appropriate text. For example: 
// 4581.34 would print “Four Thousand Five Hundred Eighty One Dollars and 34/100"
// 100.01 would print “One Hundred Dollars and 01/100” 

using System;

class aex2
{
    static void Main()
    {
        Console.Write("Please enter an amount:");
        string str = Console.ReadLine();
        // code to parse string into a double called dblAmount

        if (dblAmount <= 10000.00)
        {
            string[] strNumber = {"", "One", "Two", "Three", "Four",
                                     "Five", "Six", "Seven", "Eight", "Nine"};
									 
            string[] strTeens = // code here
            string[] strTens = // code here

            int Thousands = (int)dblAmount / 1000;
            dblAmount = dblAmount - (Thousands * 1000);
            if (???)
            {
                // code here...
            }

            // code here...
            if (Hundreds > 0)
            {
                Console.Write("{0} Hundred ", strNumber[Hundreds]);
            }

            // code here and check for teens (11 - 19)
            if (???)
            {
                // code here

                Console.Write("{0} Dollars ", strTeens[Teens - 11]);
            }
            else
            {
                int Tens = (int)dblAmount / 10;
                dblAmount = dblAmount - (Tens * 10);
                if (???)
                {
                    // code to show the Tens
                }

                int Dollars = (int)dblAmount;
                dblAmount = dblAmount - (Dollars);
                if (???)
                {
                    // code to show the Dollars
                }

                Console.Write("Dollars ");
            }

            // code to determine the Cents 
            // code to show the Cents
        }
        else
        {
            Console.WriteLine("Enter an amount less than 10000.00");
        }
        Console.ReadLine();
    }
}