using System;

namespace EjemploUsingDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ClaseEjemplo e1 = new ClaseEjemplo())
            {
                Console.WriteLine("Prueba con método Using()");
                //La llamada al método Dispose() la hace de manera implícita, por lo que evitamos poner
                //la instrucción e1.Dispose();
            }

        }
    }
}
