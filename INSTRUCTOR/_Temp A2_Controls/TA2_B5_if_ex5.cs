// File: if_ex5.cs
// write a program that would print the associated text with
// a given numeric amount as done when writing checks. 
// Assume that dollar amounts (double) are not larger than $9,999.99
// Then use the same technique that you used to convert seconds into days, hours, etc...
// Thousands = amt / 1000.00;
// amt = amt - (Thousands * 1000.00);
// console.writeline("{0} thousand ", Thousands);
// Note: There maybe some rounding errors due to minor .NET bugs

using System;

class ex5
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string strnum = Console.ReadLine();  //converting the inputed string number to double
        double amt=double.Parse(strnum);
        //int iamt=int.Parse(strnum);
		
        int ithousand;
        int ihundred;
        int idollars;
        int icent;
						
        if(amt<10000)
        {
            //... code to obtain the thousands
			//...code to show the thousands
            
            //... code to obtain the hundreds
			//...code to show the hundreds						
            
                        			
            idollars=(int)(amt);
            amt=(double)(amt-(idollars));
            Console.Write(" {0} dollars",idollars);

            icent=(int)(amt*100);
            if (icent==1)
            {
                Console.Write(" and {0} cent", icent);
            }
            else if (icent>1)
            {
                Console.Write(" and {0} cents", icent);
            }
        } 
        else
        {
            //...code to give message that the user needs to give a number less than 10,000				
        }
        Console.ReadLine();
    }

}