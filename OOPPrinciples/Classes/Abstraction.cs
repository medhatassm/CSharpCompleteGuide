using System;

namespace OOPPrinciples.Classes;

abstract class Shop // Can't create instance object from abstract class (this class have no logic).
{
    public abstract void Open();

    // Concrete
    public void Close()
    {
        Console.WriteLine("Shop Closing");
    }
}

class ClothingShop : Shop
{
    public override void Open()
    {
        Console.WriteLine("Clothing Shop Open");
    }
}

class EatingShop : Shop
{
    public override void Open()
    {
        Console.WriteLine("Eating Shop Open");
    }
}
