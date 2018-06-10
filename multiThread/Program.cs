using System;
using System.Threading;

namespace multiThread
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Thread x = new Thread(wydruk_mod2);
            Thread y = new Thread(wydruk_mod3);
            
            x.Start();
            y.Start();
            
        }

        static void wydruk_mod2()
        {
            for (int i = 0; i < 1; i++)
            {
                if(i%2==0) Console.WriteLine(i);
                
            }
        }
        
        static void wydruk_mod3()
        {
            for (int i = 0; i < 1; i++)
            {
                if(i%3==0) Console.WriteLine(i);
                
            }
        }
    }
}