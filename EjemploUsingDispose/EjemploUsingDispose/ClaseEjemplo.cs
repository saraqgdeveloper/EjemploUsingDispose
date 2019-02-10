using System;

namespace EjemploUsingDispose
{
    class ClaseEjemplo : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Llamada a método Dispose()");
        }
    }
    
}
