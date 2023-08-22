using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    internal class foreachp
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for(int i=0;i<n.Length;i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"{i} number is using for loop : {n[i]}");
            }
                foreach(int a in n)
                {
                Console.WriteLine("values using foreach:",a);
            }
                
        }
    }
}
