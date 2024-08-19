namespace Ejercicio02.Entidades
{
    public class ValidadorPatente
    {
        private string Patente = null!;

        

        public ValidadorPatente(string patente)
        {
            Patente = patente;
        }

        public void TipoPatente(string patente)
        {
            if (Patente == null)
            {
                Console.WriteLine("Error");
            }
            else if (Patente == "AAA 111")
            {
                Console.WriteLine("Formato anterior");
            }
            else if (Patente == "AA 111 AA")
            {
                Console.WriteLine("Formato nuevo");
            }
        }
    }
}
