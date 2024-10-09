using System;

namespace Collection.Models;

#region Generics Class

class Product<T, U>
{
    public T? Name { get; set; }
    public U? Price { get; set; }

    public void ShowProduct()
    {
        Console.WriteLine($"{Name}-{Price}");
    }
}

#endregion

#region Generics Method

class Print<U>
{
    public U PrintText<T>(T text, U num)
    {
        Console.WriteLine(text);
        return num;
    }
}

#endregion

#region Generics Interface

public interface IContainer<T>
{
    void Add(T name);
}

public class Box<T> : IContainer<T>
{
    public void Add(T name)
    {
        Console.WriteLine(name);
    }
}

#endregion

#region Gernerics Constrains

public interface IContainerConstrains<T> where T : class /* struct */
{
    void Add(T name);

}

public class Circle<T> : IContainerConstrains<T> where T : class
{
    public void Add(T name)
    {
        Console.WriteLine(name);
    }
}

#endregion
