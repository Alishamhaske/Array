using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class ascending
    {
        //ascending order sort array
        static void Main(string[] args)
        {

            int[] array1 = new int[5] { 23, 443, 21, 88, 22 };
            int temp = 0;
            for(int i=0;i<=array1.Length;i++)
            {
                for (int j =i+1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }

                }    
                
            }
            Console.WriteLine("ascending order: ");
            foreach (var a in array1)
            {
              
                Console.WriteLine(a);
            }

          


            /* for(int i=0;i<arr1.Length;i++)
           {
               Console.WriteLine(arr1[i]);
           }*/




        }
    }
}
