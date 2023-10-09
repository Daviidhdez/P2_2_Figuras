using System.Drawing;

namespace P2_2_Figuras;

internal class Circulo : Figura
{
    public double _radio { get; set; }

    public Circulo(Color color, double radio) : base(color)
    {
        this._radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * _radio * _radio;
    }

    public override string ToString()
    {
        return $"\nFIGURA CIRCULO \nRadio: {this._radio} {base.ToString()}";
    }
}



