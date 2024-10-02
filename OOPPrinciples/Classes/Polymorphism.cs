using System;

namespace OOPPrinciples.Classes;

// Dynamic Polymorphism (RunTime Polymorphism), Interface, Abstract classes
class Monster // Base Class
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Monster Make Sound");
    }
}

class Lion : Monster
{
    public override void MakeSound()
    {
        Console.WriteLine("Lion Make Sound");
    }
}

class Tiger : Monster
{
    public override void MakeSound()
    {
        Console.WriteLine("Tiger Make Sound");
    }
}

// Static Polymorphism (Method Overrloading) (Combile Time)

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, params int[] arr)
    {
        int total = 0;
        foreach (var item in arr)
        {
            total += item;
        }

        return total + a;
    }
}
