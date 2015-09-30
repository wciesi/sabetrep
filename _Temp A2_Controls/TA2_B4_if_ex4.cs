// Template for Student
// File: if_ex4.cs
// Write a program that accepts the hours worked and the hourly wage
// computes the employee's weekly pay, counts the overtime hours and
// calculates the overtime on time and a half basis.

using System;

class ex4
{
    static void Main()
    {	
        Console.Write("Please enter the number of hours worked: ");  
        string strHours = Console.ReadLine();
        double dblHours = double.Parse(strHours); 
	
        Console.Write("Please enter your hourly wage ($/hour): "); 
        string strWage = Console.ReadLine();
        double dblWage = double.Parse(strWage);
		
        double dblOvertimePay;
        double dblRegularPay;
        double dblTotalPay;
	
	// ...code to check if number of working hours have exceeded 40 to account for overtime pay
	// ...otherwise it will be a regular pay
        
        Console.WriteLine("Your total pay for this week is ${0}",dblTotalPay);    
    }
}			