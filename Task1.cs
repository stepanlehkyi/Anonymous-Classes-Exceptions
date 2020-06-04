using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
/*Create method Div(), which calculates the dividing of two int numbers. In
Main read two int numbers and call this method. Catch appropriative
exceptions. Throwing exception if dividing of two double numbers.*/
namespace Homework_Exeptions
{
    class Program
    {
        static int Div(int numberOne, int numberTwo)=> numberOne / numberTwo;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(Div(numberOne, numberTwo));
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(FormatException exception) when (numberOne.GetType() == typeof(double) && numberTwo.GetType() == typeof(double))
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception.Message);
            }
           


        }
    }
}
