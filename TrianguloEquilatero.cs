using System.Drawing;

namespace P2_2_Figuras;

internal class TrianguloEquilatero : Figura
{
    public double _longitudLado { get; set; }

    public TrianguloEquilatero(Color color, double longitudLado) : base(color)
    {
        this._longitudLado = longitudLado;
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * _longitudLado * _longitudLado;
    }

    public override string ToString()
    {
        return $"\nFIGURA TRIANGULO EQUILATERO \nLado: {this._longitudLado} \n{color.ToString()}";
    }
}
