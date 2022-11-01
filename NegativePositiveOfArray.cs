using System;

namespace ConsoleApp2
{
    class NegativePositive
    {
        static void Main(string[] args)
        {
            
            int pos = 0;
            int neg = 0;
            int[] num = new int[5] { -2, -4, 8, 9, 0 };
            for(int i=0;i<num.Length;i++)
            {
                if(num[i]>0)
                 {

                    pos++;
                    
                    
                 }
               else if(num[i]<0)
                {
                      neg++;
                }
                  
            }
            Console.WriteLine(pos + " sayda musbet eded, " + neg + " sayda menfi eded var");
        }
    }
}
