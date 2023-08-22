using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class maxminnum
    {
       
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter elements:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Max elements in array: {max}");

            int min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"min elements in arr: {min}");


        }

        
        
    }
}
