using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine(); */
             

            /* int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "eddie", "roger", "derek" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[1]);
            }
            Console.ReadLine(); */
            
            /*
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            
            string zig = "You can get what you want out of life " + 
                "if you help other people out.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
            
        }
    }
}
