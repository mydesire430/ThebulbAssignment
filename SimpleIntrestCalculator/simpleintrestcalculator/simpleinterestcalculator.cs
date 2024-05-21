using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace simpleintrestcalculator
{
//a class is a blueprint or a template that defines the properties,behaviors, and characteristics of an object.Its a fundamental concept in Object- Oriented Programming (OOP) and represent a real- world entity or concept.
// a class in C# typically includes:
//1. properties(data members)
//2. methods(functions)
//3. constructors
//4. Events
//5. Fields

//Note: A class in C# is defined using the "class" keyword followed by the name of the class.For example:
    public class Investment
    {
        //properties(data members) , methods(functions) ,constructors, Events ,Fields go here
        //properties
        //access modifier, data type and property name{get;set;}
        //properties, classes, methods, constructor, pascal case meaning every new word starts with capital letter
        //fields variable and parameters or arguments should be in camel case meaning the first word strat with small letter and....
        // the second word start with carpital letter or all small letters to use underscore to separate
        public double Principal { get; set; }
        public double Rate { get; set; }
        public int Time { get; set; }
        

        //method
        //the access modifier, the data type and the method name()
        public double CalculateSimpleIntrest()
        {
            var simple_intrest = (Principal * Rate * Time) / 100;
            return simple_intrest;
        }

        public double CalculateFinalAmount()
        { 
            return Principal + CalculateSimpleIntrest();
        }
        public double CalculateInterestRate(double finalAmount, double principal)
        {
            return ((finalAmount - principal) / (principal * Time)) * 100;
        }
        public int CalculateInvestmentDuration(double finalAmount, double principal, double rate) 
        {
            return (int)Math.Ceiling ((finalAmount - principal) / (principal * rate)) * 100;
        }
    }

}

