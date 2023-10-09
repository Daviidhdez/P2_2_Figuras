//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {
        // Paso 1: Creamos una instancia de cada figura

        Figura rectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3.9, 3);
        Figura circulo1 = new Circulo(Color.FromArgb(255, 0, 20, 35), 4);
        Figura circulo2 = new Circulo(Color.FromArgb(255, 230, 20, 30), 2);
        Figura triangulo = new TrianguloEquilatero(Color.FromArgb(255, 0, 20, 40), 3);


        Console.WriteLine("\nFIGURAS REALES:");
        Console.WriteLine(rectangulo);
        Console.WriteLine($"Área: {rectangulo.GetArea()}");

        Console.WriteLine(circulo1);
        Console.WriteLine($"Área: {circulo1.GetArea()}");

        Console.WriteLine(circulo2);
        Console.WriteLine($"Área: {circulo2.GetArea()}");

        Console.WriteLine(triangulo);
        Console.WriteLine($"Área: {triangulo.GetArea()}");

        // Paso 2: Modificaremos los parametros de cada figura y los mostraremos otra vez

        rectangulo.Color = Color.FromArgb(255, 0, 20, 35);
        circulo1._radio = 2.5;
        triangulo._longitudLado = 4;

        Console.WriteLine("\nDESPUES DE MODIFICAR PARAMETROS:");
        Console.WriteLine(rectangulo);
        Console.WriteLine($"Área: {rectangulo.GetArea()}");

        Console.WriteLine(circulo1);
        Console.WriteLine($"Área: {circulo1.GetArea()}");

        Console.WriteLine(triangulo);
        Console.WriteLine($"Área: {triangulo.GetArea()}");

        // Paso 3: Crearemos una lista de figuras y añadiremos 6 instancias de figuras distintas 

        List<Figura> lista_figuras = new List<Figura>();
        lista_figuras.Add(new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3.9, 3));
        lista_figuras.Add(new Circulo(Color.FromArgb(255, 0, 20, 35), 4));
        lista_figuras.Add(new Circulo(Color.FromArgb(255, 230, 20, 30), 2));
        lista_figuras.Add(new TrianguloEquilatero(Color.FromArgb(255, 0, 20, 40), 3));
        lista_figuras.Add(new Circulo(Color.FromArgb(255, 245, 40, 145), 5));
        lista_figuras.Add(new Rectangulo(Color.FromArgb(255, 100, 150, 200), 5, 6));

        // Paso 4: Veremos cada lista de figuras

        Console.WriteLine("\nLISTA DE FIGURAS:");
        foreach (var figura in lista_figuras)
        {
            Console.WriteLine(figura);
            Console.WriteLine($"Área: {figura.GetArea()}");
        }

        // Paso 5: Cambiar el color de todas las figuras en la lista

        foreach (var figura in lista_figuras)
        {
            figura.Color = Color.FromArgb(200, 245, 40, 145);
        }

        // Paso 6: Calculamos la suma de las áreas de todas las figuras de la lista

        double sumaAreas = 0;
        foreach (var figura in lista_figuras)
        {
            sumaAreas += figura.GetArea();
        }

        Console.WriteLine($"\nLA SUMA DE TODAS LAS AREAS DARA UN TOTAL DE: {sumaAreas}");
    }

}