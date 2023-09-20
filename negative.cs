using oopfirstclass_program;
using oopfirstclass_program.second_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace oopfirstclass_program.Arraypro
{
    public class negative
    {
        /*3.	WAP to print all negative elements in an array and also count total
            number of negative elements in an array.*/
        static void Main(string[] args)
        {
            int[] n3 = new int[10] { 1, 2, 3, -5, -3, 9, -43, -21, 7, 10 };
            //int count=0;
            for (int i = 0; i < n3.Length; i++)
            {

                if (n3[i] < 0)
                {
                  //  count++;
                    Console.WriteLine(n3[i]);

                }

            }
            for(int i=0;i<n3.Length; i++)
            { 
                if (n3[i]>0)
                {
                    Console.WriteLine(n3[i]);
                }
                
            }
            //Console.WriteLine("total count of negative value: "+ count);

        }
    }
}
