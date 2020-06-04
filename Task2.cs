using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*Write a method ReadNumber(int start, int end), which reads from Console
integer numbers and returns it, if it is in the range [start...end]. If an invalid
number or non-number text is read, the method should throw an exception.
Using this method write a method Main(), that has to enter 10 numbers:

a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100*/
namespace Task_2
{
    class Program
    {
        public static int ReadNumber(int start,int end)
        {
            int number = 0;
            try
            {
                Console.WriteLine("Enter a number");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception exception)
            {
                throw exception;
            }
          
            for(int i = start; i <= end; i++)
            {
                if(number == i)
                {
                    return number;
                }
            }
            return 0;
            
        } 
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
          
                list.Add(ReadNumber(1, 100));
                for (int i = 1; i < 10; i++)
                {
                    list.Add((ReadNumber(1, 100)));
                    if ((list[i] <= list[i - 1]))
                    {
                        throw new Exception("The sequence has to accept a rule: every net value should be bigger than previous one ");
                    }
                }
            Console.WriteLine("You entered: ");
         foreach(var item in list)
            {
                Console.Write(item+",");
            }
            Console.WriteLine("\b.");
        }
    }
}
