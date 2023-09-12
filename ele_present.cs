using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class ele_present
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[6];
            int cnt = 0;
            Console.WriteLine("enter a element:");
            for (int i=0;i<arr1.Length;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("enetr element to be search");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<arr1.Length;i++)
            {
                if (arr1[i]==n)
                {
                    cnt++;
                    

                }
                
            }
            if (cnt > 0)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("not present:");
            }
        }
    }
}
