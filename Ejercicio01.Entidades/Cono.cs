namespace Ejercicio01.Entidades
{
    public class Cono
    {
        public readonly double Radio;
        public readonly double Altura;

        private double Generatriz;

        public double GetGeneratriz()
        {
            Generatriz = Math.Sqrt(Math.Pow(Altura, 2) + (Math.Pow(Radio, 2)));
            return Generatriz;
        }

        public Cono(double radio, double altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public bool ValidarRadio()
        {
            return Radio > 0;
        }

        public bool ValidarAltura()
        {
            return Altura > 0;
        }

        public double GetArea()
        {
            double area = 0;
            double areaBase = 0;
            double areaLateral = 0;

            areaBase = Math.PI * Math.Pow(Radio, 2);
            areaLateral = Math.PI * Radio * Generatriz;
            area = areaBase + areaLateral;
            return area;
        }

        public double GetVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }

        public override string ToString()
        {
            return $"Cono de radio: {Radio}, n/ Altura: {Altura}" +
                $" n/ Area: {GetArea()} n/ Volumen: {GetVolumen()}";
        }

    }
}
