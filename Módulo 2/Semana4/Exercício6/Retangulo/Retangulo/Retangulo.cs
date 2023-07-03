public class Retangulo
{
    private double _largura;
    private double _altura;

    public double Largura
    {
        get { return _largura; }
        set
        {
            if (value >= 0)
            {
                _largura = value;
            }
            else
            {
                Console.WriteLine("Largura não pode ser negativa!");
            }
        }
    }

    public double Altura
    {
        get { return _altura; }
        set
        {
            if (value >= 0)
            {
                _altura = value;
            }
            else
            {
                Console.WriteLine("Altura não pode ser negativa!");
            }
        }
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
}
