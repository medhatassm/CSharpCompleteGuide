
using OOPPrinciples.Classes;

/// <Note>
/// From Now we will use Top-Level Statment Format
/// So this page will be main function as in (.Net 7 and above).
/// </Note>

#region Class Constructor

Car car = new Car();
Console.WriteLine(car.model);

Car car1 = new Car("Volvo");
#endregion

#region Extension Method

ExtensionMethodParent extensionMethod = new ExtensionMethodParent();

extensionMethod.SayHello();
extensionMethod.SayWelcome();
extensionMethod.SayWelcomeAndHello();

#endregion

#region Inhertance

DogDrivedClass newDog = new DogDrivedClass("Max", 64);  /* Dog Constructor Run First
                                                        => Then But data into base class */

// AnimalBaseClass newDog = new DogDrivedClass("Max", 64);

Console.WriteLine(newDog.Name); // Get Name From Base Class Variables.
newDog.Eat(); // Using Eat method that is in base class because no ovrride happen in dog class.
newDog.Barking(); // normal method.

CatDrivedClass newCat = new CatDrivedClass("Bussy", 20);
newCat.Eat(); // Using Eat method in cat class because its ovrride.
newCat.Mewo();

#endregion

#region Encapsulation

Person person = new Person();
person.Name = "Medhat"; // Set
Console.WriteLine(person.Name); // Get
// person.Age = 25; //! Error Read only field.
Console.WriteLine(person.Age);

#endregion

#region Polymorphism

Monster lion = new Lion();
lion.MakeSound();
Monster tiger = new Tiger();
tiger.MakeSound();

Calculator c = new Calculator();
Console.WriteLine(c.Add(2, 2));
Console.WriteLine(c.Add(5, [2, 2, 1]));

#endregion

#region Abstraction

ClothingShop clothingShop = new ClothingShop();
clothingShop.Open();
clothingShop.Close();
EatingShop eatingShop = new EatingShop();
eatingShop.Open();
eatingShop.Close();

#endregion

#region Method Hiding And Shadwing

// Method Hiding
Animal animal1 = new Animal();
Animal cat1 = new Cat();
// Cat animal2 = new Animal(); // Compilation error - cannot implicitly convert Animal to Cat
Cat cat2 = new Cat();

animal1.MakeSound(); // Output: "Animal makes a sound."
cat1.MakeSound();    // Output: "Animal makes a sound." (hiding)
cat2.MakeSound();    // Output: "Cat makes a sound."

#endregion