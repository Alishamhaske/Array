using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class unique
    {
        static void Main(string[] args)
        {
            //7.	WAP to print all unique elements in the array.

            int[] n2 = new int[10] { 7, 7, 3, 3, 43, 6, 12, 22, 33, 6 };

            for (int i = 0; i < n2.Length; i++)
            {
                int count = 0;

                for (int j = 0 ; j < n2.Length; j++)
                {
                    if (n2[j] == n2[i])

                    {
                        count++;
                        

                    }
                }

                if (count ==1)
                {
                    Console.WriteLine("  Print to all unique number: " + n2[i]);
                }


            }     //if(count>1)    //print duplicate 






        }

    }
}
