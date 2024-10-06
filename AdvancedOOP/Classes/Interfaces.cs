using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Classes
{
    public interface IShape
    {
        double CalculateArea();
    }

    public interface IColor
    {
        string GetColor();

        double CalculateArea();
    }

    public interface IColorFulShape : IShape, IColor
    {

    }
    public class Rectangle : IShape, IColor
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            return Length * Width;
        }

        public string GetColor()
        {
            return "Red";
        }
    }

    public class Circle : IColorFulShape
    {
        public double Radius { get; set; }

        double IShape.CalculateArea()
        {
            return Radius * Radius * 3.14;
        }

        double IColor.CalculateArea()
        {
            return 0;
        }

        string IColor.GetColor()
        {
            return "Blue";
        }
    }
}
