using System.ComponentModel;
using System.Drawing;

namespace P2_2_Figuras;

internal class Rectangulo : Figura

{
    public double _base { get; set; }
    public double _altura { get; set; }

    public Rectangulo(Color color, double Base, double altura) : base(color)
    {
        this._base = Base;
        this._altura = altura;
    }

    public override double GetArea()
    {
        return _base * _altura;
    }

    public override string ToString()
    {
        return $"\nFIGURA RECTANGULO \nAltura: {this._altura} \nBase: {this._base} \n{color.ToString()}";
    }
}
