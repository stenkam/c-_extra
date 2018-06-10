using System;

namespace D1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         
            Myclass obj = new Myclass();
            obj.longRun(Callback);
            
        }

        static void Callback(int i)
        {
            
            Console.WriteLine(i);
            
        }

    }    

    public class Myclass
        {

            public delegate void Callback(int i);

            public void longRun(Callback obj)
            {

                for (int i = 0; i < 100; i++)
                {

                    obj(i);

                }
                
            }
            
        
            
        }


    
}