using System;
namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 14
            // ciclo for
            
            /*sintaxis: ciclo for
            for (inicializacion; expresion; iterador)
            {
                bloque de instrucciones
            }
            ejemplo: secuencia 35-41
            */
            for (int m = 35; m <= 41; m++)
            {
                Console.WriteLine($"m: {m}");
            }
            // Definir un ciclo for para la siguiente sequencia: -33, -34, -35, -36, -37, -38, -39
            Console.WriteLine($"Ciclo 1: Descendiente");
            for(int n = -33; n >= -39; n--)
            {
                Console.WriteLine($"n: {n * -1}");
            }
            Console.WriteLine("Ciclo 2: Ascendente");
            for(int a = 9; a <= 15; a += 1)
            {
                if (a != 13)
                Console.WriteLine($"a: {a}");
            }
            for(int p = 1; p <= 539; p += 88)
            {
                int c = 1;
                Console.WriteLine($"Capitulo: {c}");
                c += 1;
                Console.WriteLine($"p: {p}");
            }
        }
    }
}