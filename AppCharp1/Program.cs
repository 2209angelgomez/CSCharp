using System;

namespace AppCharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 18;
            string nombre;
            string usuario;
            var pelicula = "EndGame";
            Console.Write("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine($"Bienvenido {nombre} tienes {edad} años");
            Console.WriteLine($"Proximo estreno {pelicula} 25 de abril");
            Console.ReadLine();


        }
    }
}
