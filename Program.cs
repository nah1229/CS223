using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string ans;
            do
            {
               
                Console.Clear();
                Console.WriteLine("Please enter grade in number ");
                 decimal number =Convert.ToDecimal(Console.ReadLine()); 
                if (number >= 90 && number <=100)
                {
                    Console.WriteLine("YOUR GRADE IS A");

                }
                if (number >= 75 && number <90)
                {
                    Console.WriteLine("YOUR GRADE IS B");

                }
                if (number >= 65 && number <75 )
                {
                    Console.WriteLine("YOUR GRADE IS C");

                }
                if (number >= 50 && number < 65)
                {
                    Console.WriteLine("YOUR GRADE IS D");

                }
                if (number < 50)
                {
                    Console.WriteLine("YOUR GRADE IS F");
                }
                if (number < 0 || number > 100)
                {
                    Console.WriteLine("ERROR NUMBER!! PLEASE REENTER THE NUMBER CORRECTLY ");
                }
                   
                Console.WriteLine("enter Y to enter grade again or other key to exit ");
                    ans = Console.ReadLine();
            } while (ans == "y" || ans == "Y");

        }
    }
}
