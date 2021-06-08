using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_LambdaAssignment
{
    delegate void MathDelegate(int numberA, int numberB);
    class Program
    {
        static void Main(string[] args)
        {
            //This app demonstrates using lambda functions to do some math based on the values entered by the user in two numbers
            Console.WriteLine("Please enter Number A:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Number B:");
            int numB = Convert.ToInt32(Console.ReadLine());

            //Create a new instance of our delegate
            MathDelegate mathDelegate;

            if (numA > numB)
            {
                //Subtract A - B
                //Lambda format:  delegate = (input parameters) => { method body / contents };
                //Notice you can drop the data type of the input parameters if they can be inferred from the method
                mathDelegate = (numberA, numberB) => { Console.WriteLine($"{numberA} - {numberB} = {numberA - numberB}."); };
            }
            else
            {
                //Subtract B - A
                mathDelegate = (numberA, numberB) => { Console.WriteLine($"{numberB} - {numberA} = {numberB - numberA}."); };
            }

            //Multiply A * B
            mathDelegate += (numberA, numberB) => { Console.WriteLine($"{numberA} * {numberB} = {numberA * numberB}."); };

            if (numA > 0 && numB > 0)
            {
                //Divide A / B
                mathDelegate += (numberA, numberB) => { Console.WriteLine($"{numberA} / {numberB} = {numberA / numberB}."); };

                //Divide B / A
                mathDelegate += (numberA, numberB) => { Console.WriteLine($"{numberB} / {numberA} = {numberB / numberA}."); };
            }

            //Execute all the chained-together delegates
            mathDelegate(numA, numB);

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
