using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //listasSimple();

            listasConObjetos();
        }

        static void listasConObjetos()
        {
            //inicializar lista con objetos
            List<Persona> personas = new List<Persona>();

            //agregar objeto persona a lista CON referencia del objeto persona
            Persona persona = new Persona();

            persona.dni = 1000;
            persona.nombre = "Jose";
            persona.apellido = "Perez";

            personas.Add(persona);

            //agregar objeto persona a lista SIN referencia del objeto persona
            personas.Add(new Persona()
            {
                dni = 2000,
                nombre = "Juan",
                apellido = "Martinez"
            });

            personas.Add(new Persona()
            {
                dni = 3000,
                nombre = "Pedro",
                apellido = "Picapiedra"
            });

            personas.Add(new Persona()
            {
                dni = 4000,
                nombre = "Pablo",
                apellido = "??"
            });

            foreach (Persona p in personas)
            {
                System.Console.WriteLine($"Nombre: {p.nombre}, Apellido: {p.apellido}, DNI: {p.dni}");
            }
        }

        static void listasSimple()
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

            //eliminar un elemento de la lista, metodo Remove

            numeros.Add(1000);
            numeros.Add(2000);

            InformarLista(numeros);

            numeros.Remove(2000);

            InformarLista(numeros);
            System.Console.WriteLine("Remove");

            //eliminar elemento de la liste, metodo RemoveAt

            numeros.RemoveAt(4);

            InformarLista(numeros);
            System.Console.WriteLine("RemoveAt");

            numeros.RemoveAll(numero => numero > 40);

            InformarLista(numeros);
            System.Console.WriteLine("RemoveAll");

            //ordenar numeros creciente o ascendente
            numeros.Sort();

            InformarLista(numeros);
            System.Console.WriteLine("Sort");


            //ordenar numeros decreciente o descendente
            numeros.Sort();

            numeros.Reverse();

            InformarLista(numeros);
            System.Console.WriteLine("Reverse");

            System.Console.WriteLine("-----------------------");

            //informar por pantalla con metodo "ForEach"

            numeros.ForEach(x =>
            {
                Console.WriteLine(x);
            });


            System.Console.WriteLine("ForEach");
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
