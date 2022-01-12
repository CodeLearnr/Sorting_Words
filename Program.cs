using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA16_WordSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1;
            Console.WriteLine("Enter a sentence to be sorted: ");
            str1 = Console.ReadLine();
            string[] parts = str1.Split(' ');

            Console.WriteLine("=== Sorting by lenth: === ");
            Array.Sort(parts, (x, y) => x.Length.CompareTo(y.Length));
            foreach(string word in parts)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n=== Sorting by alphabet: ===");
            
            Array.Sort(parts);   //sort in ascending order
                      
            foreach (string word in parts)
            {
                Console.WriteLine(word);
            }
            
            Console.ReadLine();
        }
    }
}
