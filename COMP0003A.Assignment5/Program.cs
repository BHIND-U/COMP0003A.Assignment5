/* Author: Joshua Isidro
 * Course: COMP-003A
 * Purpose: Code for Assignment 5
 */


using System.Security.Cryptography;

namespace COMP0003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Triangle Section".PadLeft(25));
            

            PrintSeparator();
            Console.Write("Enter a single character:");
            char InputCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a positive whole number:");
            int size = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(InputCharacter, size);

            

            PrintSeparator();    
            Console.WriteLine("Favorite Characters Section".PadLeft(35));
            CharacterInfo("Black Panther", 1966);
            CharacterInfo("Batman", 1915);
            CharacterInfo("Superman", 1938);
            CharacterInfo("Venom", 1982); 
            CharacterInfo("Spiderman", 1962);

            Console.WriteLine("**************************************************");

        }

        /// <summary>
        /// Seperator, has 50 "%" symbols
        /// </summary>
        static void PrintSeparator () 
        {
            Console.WriteLine(new string('%', 50));
        }

        /// <summary>
        /// Example of method overloading
        /// </summary>
        /// <param name="xd"></param>
        static void PrintSeparator(string xd) 
        {
            PrintSeparator ();
            Console.WriteLine($"{xd}");
            PrintSeparator ();
        }
        
        /// <summary>
        /// creates an isosceles triangle by increasing in intervals of 1 character of your choice until it reaches the inputted value and then decreases by 1
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter,i));
            }
            for (int i = size - 1;  i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter,i));
            }
        }

        /// <summary>
        /// Calculator for age, subtracts the current year by the inputted year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }

        /// <summary>
        /// retrieves the age from the code above then creates a message using the information 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }
    }
}
