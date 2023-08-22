using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class tranverse
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int[] arr1 = new int[5] { 1, 33, 66, 88, 11 };
            int[] arr2 = new int[6] { 1, 23, 44, 2, 11, 2 };
            for (int i = 0; i <= arr1.Length; i++)
            {
                
                for (int j = 0; j < arr1.Length; j++)
                {
                   
                    if (arr1.Length==arr2.Length)
                    {
                        flag = true;
                    }
                    
                }
               


            }
            if (flag == true)
            {
                Console.WriteLine("both array are same length");
            }
            else
            {
                Console.WriteLine("not same length");
            }







        }

    }
}
