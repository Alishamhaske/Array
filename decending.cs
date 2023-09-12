using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class decending
    {
        //ascending order sort array
        static void Main(string[] args)
        {
            int[] arr1 = new int[10] { 2, 8, 6, 9, 1, 22, 3, 56, 7, 8 };
            int temp = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;

                    }

                }


            }
            /* for(int i=0;i<arr1.Length;i++)
             {
                 Console.WriteLine(arr1[i]);
             }*/

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }




        }
    }
}
