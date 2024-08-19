using Ejercicio02.Entidades;
using MiDll;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patente = ConsoleExtensions.ReadString("Ingrese su patente: ");
            ValidadorPatente validador = new ValidadorPatente(patente);

            validador.TipoPatente(patente);


        }


    }
}
