using System;

namespace OOPPrinciples.Classes;

public class Animal // Base Class
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

public class Cat : Animal // Child Class
{
    public new void MakeSound() // new keyword use to achive Hiding Method
    {
        Console.WriteLine("Cat makes a sound.");
    }
}

/// Shadowing Method:  
/// Same as Hiding Method but without using polymorphism it will just act like Hiding Method,
/// this can lead to unexpected behavior as the base class method may still be invoked when
/// calling the method on an object of the derived class.
/// (Just Remove virtual keyword and new keyword).
