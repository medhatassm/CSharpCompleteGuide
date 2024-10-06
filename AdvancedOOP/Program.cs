using AdvancedOOP.Classes;

#region Interface

Rectangle rectangle = new Rectangle();
rectangle.Length = 20.2;
rectangle.Width = 18.23;
rectangle.CalculateArea();
Circle circle = new Circle();
circle.Radius = 3.21;
IShape shape = circle;
Console.WriteLine(shape.CalculateArea());
IColor color = circle;
Console.WriteLine(color.CalculateArea());

#endregion

#region Structures

Point p = new Point(2, 3);
Console.WriteLine(p.x);
p.MovePoint(); // x can't increment becuse structures is Value Type
Console.WriteLine(p.x);

#endregion

#region Enumeration

// Convert enum to int
var m = (int)DaysOfWeek.Friday;
Console.WriteLine(m);

// Convert int to enum
int x = 5;
var z = (DaysOfWeek)x;
Console.WriteLine(z);

Console.Write("Enter The Light Number: ");
int input = Convert.ToInt32(Console.ReadLine());

var enumInput = (TraffecLight)input;

switch (enumInput)
{
    case TraffecLight.Red:
        {
            Console.WriteLine("Start");
            break;
        }
    case TraffecLight.Yellow:
        {
            Console.WriteLine("Prepare");
            break;
        }
    case TraffecLight.Green:
        {
            Console.WriteLine("Go");
            break;
        }
    default:
        {
            Console.WriteLine("Chose number between 1 - 3 in next time");
            break;
        }
}

#endregion

#region Static Keyword

Family.FatherName = "Ziad";
Family.MotherName = "Ola";
Console.WriteLine(Family.HasFamily());

Vichel car = new Vichel();
Vichel car2 = new Vichel();
Vichel.NumberOfCalls = 5;
Vichel.Drive();

#endregion