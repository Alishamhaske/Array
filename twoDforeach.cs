using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class twoDforeach
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
                { 2,4,5,7},
                { 5,6,7,9},
                { 8,9,11,3}
            };
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}
