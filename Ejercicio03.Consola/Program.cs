class Program
{
    static void Main()
    {
        Kilometros km1 = new Kilometros(10);
        Millas mi1 = new Millas(6.21371f);

      
        Kilometros km2 = 20f;
        Millas mi2 = 12f;

      
        Millas miConvertida = (Millas)km1;
        Kilometros kmConvertido = (Kilometros)mi1;

       
        Kilometros kmResultado = km1 + kmConvertido;
        Millas miResultado = mi1 + miConvertida;

  
        bool sonIgualesKm = km1 == kmConvertido;
        bool sonIgualesMi = mi1 == miConvertida;

        Console.WriteLine($"km1: {km1.ObtenerDistancia()} km");
        Console.WriteLine($"miConvertida: {miConvertida.ObtenerDistancia()} mi");
        Console.WriteLine($"kmResultado: {kmResultado.ObtenerDistancia()} km");
        Console.WriteLine($"miResultado: {miResultado.ObtenerDistancia()} mi");
        Console.WriteLine($"sonIgualesKm: {sonIgualesKm}");
        Console.WriteLine($"sonIgualesMi: {sonIgualesMi}");
    }
}