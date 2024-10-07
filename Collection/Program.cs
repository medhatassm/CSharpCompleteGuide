using Collection.Models;

#region Generics

#region Generics Class
Product<string, int> product = new Product<string, int>()
{
    Name = "P1",
    Price = 20
};

product.ShowProduct();

Product<string, decimal> productTwo = new Product<string, decimal>()
{
    Name = "P1",
    Price = 20.50m
};

productTwo.ShowProduct();

Product<int, double> productThree = new Product<int, double>()
{
    Name = 2,
    Price = 20.19
};

productThree.ShowProduct();

#endregion

#region Generics Method

Print<int> print = new Print<int>();
print.PrintText<string>("Hello", 10);

#endregion

#region Gernerics Constrains

Circle<string> circle = new Circle<string>();

circle.Add("Medhat");

//! Error Becuse T is Reference Type Only

// Circle<int> circle = new Circle<int>();

// circle.Add(10);

#endregion

#endregion

