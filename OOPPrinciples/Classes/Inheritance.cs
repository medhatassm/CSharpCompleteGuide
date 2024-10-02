using System;

namespace OOPPrinciples.Classes;

public class AnimalBaseClass
{
    public string? Name { get; set; }
    public int Wight { get; set; }

    public AnimalBaseClass(string Name, int Wight)
    {
        this.Name = Name;
        this.Wight = Wight;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} Is Eating");
    }
}

class DogDrivedClass : AnimalBaseClass
{
    public DogDrivedClass(string Name, int Wight) : base(Name, Wight)
    {
        Console.WriteLine("Dog Constructor");
    }
    public void Barking()
    {
        Console.WriteLine("Woh Woh ...");
    }

    // public override void Eat()
    // {
    //     Console.WriteLine("Dog is Eating");
    // }
}

class CatDrivedClass : AnimalBaseClass
{
    public CatDrivedClass(string Name, int Wight) : base(Name, Wight)
    {
        Console.WriteLine("Cat Constructor");
    }
    public void Mewo()
    {
        Console.WriteLine("Mewo Mewo ...");
    }
    public override void Eat()
    {
        Console.WriteLine("Cat is Eating");
    }
}

sealed class AnimalMoreInfo
{
    public AnimalMoreInfo()
    {
        Console.WriteLine("This is Fantasi Animal");
    }
}

class Unicon // : AnimalMoreInfo //! Error: 'Unicon': cannot derive from sealed type 'AnimalMoreInfo'
{
    public Unicon()
    {

    }
}