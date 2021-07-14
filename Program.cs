using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear lista de numeros enteros, hay dos formas:

            //1) en dos lineas

            //declara una variable de tipo List<int>
            List<int> numerosEnDosLineas;

            //se instancia un objeto de tipo List<int>
            numerosEnDosLineas = new List<int>();

            //2) declarar e instanciar el objeto List<int> en una linea (recomendada)

            List<int> numeros = new List<int>();

            //agregar elementos a una lista

            numeros.Add(22);
            numeros.Add(42);
            numeros.Add(63);
            numeros.Add(85);
            numeros.Add(27);

            //recorrer una lista con "ciclo de iteracion" foreach
            InformarLista(numeros);

            System.Console.WriteLine($"Cantidad elementos lista: {numeros.Count}");

            //eliiminar todos los objetos de la lista
            numeros.Clear();

            InformarLista(numeros);

            System.Console.WriteLine($"Cantidad elementos lista: {numeros.Count}");

            //verificar si un elemento pertenece a una lista
            bool resultado = numeros.Contains(42);

            System.Console.WriteLine($"Contains: {resultado}");

            //genero 10 numeros aleatorios enteros y se almacenan en lista
            Random aleatorio = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(aleatorio.Next(100));
            }

            InformarLista(numeros);

        }

        static void InformarLista(List<int> numeros)
        {
            System.Console.WriteLine("-----------------------");

            foreach (int numero in numeros)
            {
                System.Console.WriteLine(numero);
            }
        }
    }
}
