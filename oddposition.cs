using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class oddposition
    {
        static void Main(string[] args)
        {
            //write code to display element of odd position
            int[] arr2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr2[i];i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(arr2[i]);
                }
            }

        }
        
    }
}
