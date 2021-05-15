using System;

namespace DesafioDIOPimentoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            string[] entrada = (Console.ReadLine()).Split(" ");
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            x = a + b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);
        }
    }
}
