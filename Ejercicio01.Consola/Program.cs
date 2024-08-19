using Ejercicio01.Entidades;
using MiDll;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio = ConsoleExtensions.ReadDouble("Ingrese el radio del cono: ");
            double altura = ConsoleExtensions.ReadDouble("Ingrese la altura del cono: ");
            Cono cono = new Cono(radio, altura);

            Console.WriteLine($"Cono de area: {cono.GetArea()}");
            Console.WriteLine($"Cono de volumen: {cono.GetVolumen()}");
        }
    }
}
