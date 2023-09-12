using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    internal class reversearray
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("reverse array is:");
            for(int i=array.Length-1;i>=0;i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
