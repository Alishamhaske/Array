using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class evensum
    {
        static void Main(string[] args)
        {
            //write code to display sum of even element in array
            int[] arr1 = new int[5];
            int sum = 0;
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine("enter a elements");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr1.Length;i++)
            {
                if (arr1[i]%2==0)
                {
                    //Console.WriteLine(i);
                    sum = sum + arr1[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
