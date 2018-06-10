using System;
using System.Threading;
using System.Threading.Tasks;

namespace ASync
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Główny wątek");
            
        }

        public static async void Method()
        {

            await Task.Run(new Action(Czekaj));
            Console.WriteLine("Nowy wątek");

        }

        public static void Czekaj()
        {
            
            Thread.Sleep(100000);
            
        }
    }
}