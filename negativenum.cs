using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class negativenum
    {
        //count negative number
        static void Main(string[] args)
        {
            int[] negative = new int[10];
            int count = 0;
            Console.WriteLine("enter a numbers:");
            for (int i=0;i<negative.Length;i++)
            {
            
                 negative[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<negative.Length;i++)
            {
                if (negative[i]<0)
                {
                    count++;
                    Console.WriteLine($" neagtive number: {negative[i]}");

                }
               
            }
            Console.WriteLine("total negative number: " + count);

        }
    }
}
