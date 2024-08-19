public class Millas
{
    private float distancia;

    public Millas(float distancia = 100)
    {
        this.distancia = distancia;
    }

    public float ObtenerDistancia()
    {
        return distancia;
    }


    public static implicit operator Millas(float d)
    {
        return new Millas(d);
    }


    public static explicit operator Kilometros(Millas mi)
    {
        return new Kilometros(mi.distancia * 1.60934f);
    }


    public static bool operator ==(Millas mi1, Millas mi2)
    {
        return mi1.distancia == mi2.distancia;
    }

    public static bool operator !=(Millas mi1, Millas mi2)
    {
        return !(mi1 == mi2);
    }

    public static Millas operator +(Millas mi1, Millas mi2)
    {
        return new Millas(mi1.distancia + mi2.distancia);
    }

    public override bool Equals(object obj)
    {
        if (obj is Millas)
        {
            return this == (Millas)obj;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return distancia.GetHashCode();
    }
}