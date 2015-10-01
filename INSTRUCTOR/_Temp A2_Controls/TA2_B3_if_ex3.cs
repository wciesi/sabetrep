// File: Template for Student
// File: if_ex3.cs
// Write a program to take given seconds and 
// convert it into days, hours, minutes and some left over seconds.
// Hint: 1 day = 86400 seconds, 1 hour = 3600 seconds, 1 min = 60 seconds

using System;

class ex3
{
    static void Main()
    {
        // ...code to ask user to give you a large number 
		
        // ...code to read and assign the given input into a number
        
		// obtain number of days
        int days = x/86400;
        x=x-(days*86400);

        if (days>1)
        {
            Console.WriteLine("{0} days ",days);
        }
        else if (days==1)
        {
            Console.WriteLine("1 day ");
        }
		
		// ...code to obtain number of hours
        
        // ...code to obtain number of minutes
		
		// ...code to obtain number of seconds

        Console.ReadLine();
    }
}