using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Arraypro
{
    public class userip
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            for (int i = 0; i <s.Length;i++)
            {
                Console.WriteLine("enter a name");
                s[i] = Convert.ToString(Console.ReadLine());
            }
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine($"{i} string is: {s[i]}");
            }
        }
    }
}
