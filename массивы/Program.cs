using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChisloE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] count =  new int[2];
            count[0] = 1;
            count[1] = 2;
            
            for (int i = 0; i < count.Length; i++)
            {
                Console.WriteLine(count[i]);    
            }
        }
          
    }

}






