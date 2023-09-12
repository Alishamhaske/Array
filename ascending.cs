using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class ascending
    {
        //ascending order sort array
        static void Main(string[] args)
        {

            int[] array1 = new int[5];
            int temp = 0;
            Console.WriteLine(  "enter a elements");

            for(int i = 0; i < array1.Length;i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<array1.Length;i++)
            {
                for(int j=i+1;j<array1.Length;j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }
            Console.WriteLine( "after decending");
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        
            Console.WriteLine(  "enter a nth min elemnet:");
            int n = Convert.ToInt32(Console.ReadLine());
             for(int i=1;i<array1.Length;i++)
            {
                if(i==n)
                {
                    Console.WriteLine(i-1);
                }
            }
           


            /* for(int i=0;i<arr1.Length;i++)
           {
               Console.WriteLine(arr1[i]);
           }*/




        }
    }
}
