using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // Declaracion de variales

            string? marca_Zapatos;
            string? color_Zapatos;

            int cantidad;
            double precio_Zapato;

            // Captura de datos
            Console.WriteLine("\n--------- capturando variables------------");
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar: ");
            marca_Zapatos = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color de zapatos: ");
            color_Zapatos = Convert.ToString(Console.ReadLine());

            Console.ForegroundColor =ConsoleColor.Green;
            Console.WriteLine("\nIngrese la cantidad de pares dezapatos a comprar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese el precio de los pares de zapatos a comprar: ");
            precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("---------Fin de capturacion de  variables------------\n");

            // Capturando el total a pagar
            double total = cantidad * precio_Zapato;

            // Imprimiendo resultado
            Console.WriteLine("-------------Imprimiendo resultados------------\n");
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.WriteLine("La marca de zapatos a comprar es : " + marca_Zapatos);
            Console.WriteLine("\n El color  de los zapatos a comprar es : " + color_Zapatos);
            Console.ForegroundColor =ConsoleColor.Green;
            Console.WriteLine("\n La cantidad de zapatos a comprar es : " + cantidad);
            Console.WriteLine("\n El precio por par de zapatos a comprar es : " + precio_Zapato);
            Console.ForegroundColor =ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n El total a pagar es: " + total);
            Console.WriteLine("-------------Fin de Impresion de  resultados------------\n");
            Console.ResetColor();






        }
    }
}