using oopfirstclass_program.second_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.Array
{
    public class duplicate
    {
        // find and count total number of duplicate elements in an array.
        static void Main(string[] args)
        { 
      
            int[] n2 = new int[10] { 7,7, 3, 3,3, 6 ,2,2,2,6};
         
            for(int i=0;i<n2.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k=i-1;k>=0;k--)
                {
                    if (n2[k] ==n2[i])

                    {
                        isvisited = true;
                        break;
                     
                    }

                }
                if(isvisited==false)
                {
                    for(int j = i + 1; j < n2.Length;j++)
                    {
                        if (n2[i] == n2[j])
                        {
                            count++;
                        }
                    }
                    //if(count==1)    //print unique 
                    if(count>1)
                    {
                        Console.WriteLine("  count of  "+n2[i] +" number  is "+count);
                    }
                }

             

            }

        }
    }
}
