using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class even
    {
        static void Main(string[] args)
        {
            int[] even = new int[10];
            for(int i=0;i<even.Length;i++)
            {
                Console.WriteLine($"enter a number: {i}");
                even[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("print all even values: ");
            for (int i=0;i<even.Length;i++)
            {
                if(even[i]%2==0)
                {
                    Console.WriteLine($" {even[i]} ");
                }

            }
        }
    }
}
