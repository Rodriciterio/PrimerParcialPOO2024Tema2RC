using Ejercicio03.Entidades;

public class Kilometros
{
    private float distancia;

    public Kilometros(float distancia = 100)
    {
        this.distancia = distancia;
    }

    public float ObtenerDistancia()
    {
        return distancia;
    }

    public static implicit operator Kilometros(float d)
    {
        return new Kilometros(d);
    }

 
    public static explicit operator Millas(Kilometros km)
    {
        return new Millas(km.distancia * 0.621371f);
    }

    // Sobrecarga de operadores de igualdad
    public static bool operator ==(Kilometros km1, Kilometros km2)
    {
        return km1.distancia == km2.distancia;
    }

    public static bool operator !=(Kilometros km1, Kilometros km2)
    {
        return !(km1 == km2);
    }

   
    public static Kilometros operator +(Kilometros km1, Kilometros km2)
    {
        return new Kilometros(km1.distancia + km2.distancia);
    }

    public override bool Equals(object obj)
    {
        if (obj is Kilometros)
        {
            return this == (Kilometros)obj;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return distancia.GetHashCode();
    }
}