using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class alternate
    {
        static void Main(string[] args)
        {
            //display alternate element
            int[] arr1 = new int[10];
            //{ 12, 22, 33, 42, 25, 86, 70, 28, 19, 10 };
            Console.WriteLine("enter a numbers");
            for (int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("alternate element");

           for(int i=0;i<arr1.Length;i++)
            {
               if(i%2==0)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
         
        }
    }
}
