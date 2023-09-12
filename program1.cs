using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class program1
    {
        //WAP to accept rainfall for a week from the user & display the rainfall using an array.

        static void Main(string[] args)
        {
            int[] rainfall = new int[7];   
            for(int i=0;i<rainfall.Length;i++)
            {
                Console.WriteLine($"enter a rainfall value for {i} day in week");
                rainfall[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Print all the values");

        for(int i=0;i<rainfall.Length;i++)
            {
                Console.WriteLine($"rainfall in {i} day in week = {rainfall[i]}");
            }

        }
    }
}
