using System;
namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque de la función
            // Sesión 15: Funciones 15102026
            /*
            Función: Bloque de instrucciones para realizar una tarea especifica, que se ejecuta, unicamente, cuando es invocado.
            Sintaxis: Definición de función
            tipo_dato_devuelto identificador_función(parámetros)
            {
                Bloque de instrucciones
            }
            Nota: Los parámetros se definen incluyendo el tipo de dato.
            Nota 2: Los parámetros van separados por comas.
            Sintaxis: Invocación función
            identificador_funcion(argumentos);
            Argumento: El valor del parámetro.
            */
            // Ejemplo 1: Función vacia sin parámetros
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"Hola, {salón}!");
            }
            // Invocación
            Saludar();
            // Ejercitación
            // 1. Definir e invocar una función sin parámetros para imprimir: nombre, clave y salón.
            void Datos()
            {
                string información = "Ian Ramirez Hernandez 331-29";
                Console.WriteLine(información);
            }
            Datos();
            // 2. Definir e invocar una función sin parámetros para desplegar el horario de todas las clases
            void Horario()
            {
                string clase_1 = "7:00: Cálculo";
                string clase_2 = "7:50: FH";
                string clase_3 = "8:40 Programación";
                string clase_4 = "9:50: Psicología";
                string clase_5 = "10:40: Idiomas";
                string clase_6 = "11:50: Dibujo";
                string clase_7 = "12:40: Dibujo";
                Console.WriteLine(clase_1);
                Console.WriteLine(clase_2);
                Console.WriteLine(clase_3);
                Console.WriteLine(clase_4);
                Console.WriteLine(clase_5);
                Console.WriteLine(clase_6);
                Console.WriteLine(clase_7);
            }
            Horario();
        }
    }
}