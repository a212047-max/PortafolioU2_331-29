using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30092026
            // Sintaxis: While
            // Inicializaición;
            // while(expresión)
            // {
            //      bloque de instrucciones
            //      iterador;
            // }
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente
            int m = 1; // Inicialización
            while(m <= 3)
            {
                // Bloque de instrucciones
                m += 1;
                Console.WriteLine($"m: {m}");
            }
            //Ejercitación
            //1. Definir un ciclo para imprimir tu nombre 5 veces.
            //Nota: Para la expresión, utilizar el operador <.
            int n = 0;
            while(n < 5)
            {
                Console.WriteLine($"Impresion: {n + 1} Tu nombre: Ian Ramirez.");
                n += 1;
            }
            // b. Ciclo descendente
            int d = 3;
            while(d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d-=1;
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            //Ejercitación:
            int x = 16;
            while(x > 0)
            {
                Console.WriteLine("331");
                x -= 2;
            }
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: Para la solución, utilizar el operador de diferencia
            int a = 1;
            while(a != 0)
            {
                Console.WriteLine(a);
                a += 1;
            }
            int z = 0;
            while(z != 1)
            {
                Console.WriteLine(z);
                z -= 1;
            }
        }
        
    }
}