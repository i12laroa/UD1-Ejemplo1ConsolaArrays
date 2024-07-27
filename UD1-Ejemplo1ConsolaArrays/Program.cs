using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ejemplo1ConsolaArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vamos a crear un array con 3 palabras
            string[] palabras = new string[3];
            int contador = 0;

            //Realizamos un bucle para contar las palabras
            while (contador != 3)
            {
                Console.WriteLine($"Introduce una palabra en nuestro array (Posición {contador+1}):");
                palabras[contador] = Console.ReadLine();
                contador++;
            }

            //Mostramos el array introducido
            foreach(string palabra in palabras) { Console.WriteLine(palabra); }

        }
    }
}
