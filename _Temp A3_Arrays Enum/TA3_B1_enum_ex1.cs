//File: enum_ex1.cs
// write a program that determines the number of days for a month
// using a switch statement.  The program should accept the number of the month in question.
using System;

enum eMonthNames
{	
    // code here to specify months
}
enum eMonthDays // showing number of days associated with each month
{
    January=30,
    February=29,
    March=31,
    April=31,
    May=30,
    June=31,
    July=31,
    August=31,
    September=31,
    October=31,
    November=31,
    December=31,
	
}
class MonthSwitch
{
    
    static void Main()
    {
        while(true) // This will keep the console up and keeps allowing to make a selection
        {
            eMonthNames eName;
		
            Console.Write("Please enter a Month Number: ");
            string strName = Console.ReadLine();

            int nDays=0;
		
            switch (???)
            {
                case "1":
                    // code for case 1				                    
                case "2":
                    // code for case 2
                case "3":
                    eName=eMonthNames.March;
                    nDays=(int)eMonthDays.March;				
                    break;
                case "4":
                    // code for case 4 and continue...
               // code what the default should be
            }
			
            // finally show the month name and its associated days 
        }
    }
}     