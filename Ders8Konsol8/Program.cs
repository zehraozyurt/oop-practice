using Ders8Konsol8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ders8Konsol8
{
    public abstract class GeometriShapes
    {
        private string name;
        public abstract double geometricArea();

        public void geometricName(string name)
        {
            this.name = name;
        }

    }
    public class Rectangle : GeometriShapes
    {
        private double a;
        private double b;

        public void information(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double geometricArea()
        {
            return a * b;
        }
    }

}
public class Triangel : GeometriShapes
{
    private double height, bases;
    public void information(double height , double bases )
    {
        this.height = height;
        this.bases = bases;
    }
    public override double geometricArea()
    {
        return (height * bases) / 2;
    }
}
public class Circle : GeometriShapes
{
    private double radius;
    private double pi = Math .PI;

    public void information(double radius)
    {
        this.radius= radius;
    }
    public override double geometricArea()
    {
        return pi * radius;
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        Circle daire = new Circle();
        Rectangle dikdortgen = new Rectangle();
        Triangel ucgen = new Triangel();

        daire.information(4.0);
        dikdortgen.information(5.0, 8.0);
        ucgen.information(5.0, 10.0);

        Console.WriteLine("Daire Alani : " + daire.geometricArea());
        Console.WriteLine("Ucgen Alani : " + ucgen.geometricArea());
        Console.WriteLine("Dikdortgen Alani : " + dikdortgen.geometricArea());
    
    }
}

