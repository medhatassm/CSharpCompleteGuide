## Object Oriented Programming Principles (OOP)

> OOP enable developers to think in terms of object, classes and method, making code more intuitive and easier to maintain.
> 

### Classes & Objects

class and object are tow main aspect of OOP, So a class is a template for object, and object is an instance of a class like image below.

![Screenshot 2024-10-01 at 2.58.23 PM.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/ac8d2e56-c643-48fc-af41-f14c17164785/90ead6a3-d4dd-459c-a841-0a0d8a19036d/Screenshot_2024-10-01_at_2.58.23_PM.png)

- **Class Members**
    
    Variables inside a class called ***Fields***, and that you can access them by create an object of the class.
    
    - **Variables (Properties) Description of Class Properties**
    - **Method (Behavior) Description of Class Behavior (What it can do!)**
    
    ```csharp
    public class Car
    {
        public string _type = "Nissan";
        public string _color = "Red";
        public double _kmh = 50000;
    
        public string MoverForword()
        {
            return "Car Moved forword.";
        }
    }
    ```
    
- **Class Constructors**
    
    is a special method that is used to initialize object.
    
    **The Advantage of a constructors:**
    
    - That its called when an object of a class created.
    - it can be used to set initial values for fields.

```csharp
class Car{

		public string model;
		
		public Car()
		{
		    model = "Nissan";
		}
		
}
```

```csharp
class Program{

		Car car = new Car();
		Console.WriteLine(car.model);

}
```

```csharp
class Car{

		public string model;
		
		 public Car(string Model)
    {
        model = Model;
    }
		
}
```

```csharp
class Program{

		Car car = new Car("Volvo");
		
}
```

- Constructor Chaining
    
    a technique in C# that allow one constructor to call another constructor of the same class or a class base (parent)
    
    ```csharp
    // First Constructo
    public Car() : this("Volvo") 
    {
        model = "Nissan";
    }
    
    // Second Constructor
    public Car(string Model)
    {
        model = Model;
    }
    ```
    
    ```csharp
    Car car = new Car();
    Console.WriteLine(car.model); // "Nissan"
    ```
    
- **Extension Method**
    
    allows you to add new methods in the existing **class** or in the **structure** without modifying the source code of the original type.
    
    > The child class that have method you add have to be static.
    > 

```csharp
public class ExtensionMethodParent
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }

    public void SayWelcome()
    {
        Console.WriteLine("Welcome");
    }
}
```

> Now you can Call **SayWelcomeAndHello** Function with **ExtensionMethodParent** instant object in your entry point (Main).
> 

```csharp
static public class ExtensionMethodChild
{
    public static void SayWelcomeAndHello(this ExtensionMethodParent extentionMethodParent)
    {
        Console.WriteLine("Hello And Welcome");
    }

}
```

```csharp
ExtensionMethodParent extensionMethod = new ExtensionMethodParent();

extensionMethod.SayHello();
extensionMethod.SayWelcome();
extensionMethod.SayWelcomeAndHello();
```

---

### Access Modifiers

- **Public →** The Code is accessible for all classes
- **Private →** The Code is only accessible within the same class
    
    > if you didn’t declare any access modifiers compiler will use **Private** as default one.
    > 
- **Internal →** The Code is only accessible within its own assembly (DLL Folder), but not from another assembly(DLL Folder)
- **Protected →** The Code is accessible within the same class, or in a class that inherited from it

---

### OOP Principles Concept

- **Inheritance**
    
    inherit fields and methods from one class to another, inheritance concept into two category:
    
    - Derived Class (Child) : that class that inherits from another class
    - Base Class (Parent) : that class being inherited from.
    
    > **To inherit use `:` symbol between classes.**
    > 

![7c56f17b-aaa7-4472-a65f-c7767ec5f243_1412x1062.jpg](https://prod-files-secure.s3.us-west-2.amazonaws.com/ac8d2e56-c643-48fc-af41-f14c17164785/8aeef5e9-b9c6-4a10-b046-ca217a8b5858/7c56f17b-aaa7-4472-a65f-c7767ec5f243_1412x1062.jpg)

```csharp
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
```

- **Virtual Keyword**
    
    The `virtual` keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
    
- **Override Keyword**
    
    in Derived Class (Child) using `override` keyword to tell the compiler that this method will be override from original one in parent class (Base Class).
    

```csharp
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
    //    Console.WriteLine("Dog is Eating");
    // }
}
```

```csharp
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

```

```csharp
DogDrivedClass newDog = new DogDrivedClass("Max", 64);  /* Dog Constructor Run First
                                                        => Then But data into base class */

// AnimalBaseClass newDog = new DogDrivedClass("Max", 64);

Console.WriteLine(newDog.Name); // Get Name From Base Class Variables.
newDog.Eat(); // Using Eat method that is in base class because no ovrride happen in dog class.
newDog.Barking(); // normal method.

CatDrivedClass newCat = new CatDrivedClass("Bussy", 20);
newCat.Eat(); // Using Eat method in cat class because its ovrride.
newCat.Mewo();
```

- **Sealed Keyword :** That Prevent class to inherit from a class
    
    ```csharp
    // Parent (Sealed)
    sealed class AnimalMoreInfo
    {
        public AnimalMoreInfo()
        {
            Console.WriteLine("This is Fantasi Animal");
        }
    }
    
    // Child (Can't inherit from parent)
    class Unicon // : AnimalMoreInfo //! Error: 'Unicon': cannot derive from sealed type 'AnimalMoreInfo'
    {
        public Unicon()
        {
    
        }
    }
    ```
    
    ---
    
- **Encapsulation (Properties)**
    
    is to make sure that “**Sensitive**” data is hidden from user to access them you have to: provide (get & set) method. through properties to access and update the value of private field.
    
    ```csharp
    class Person
    {
        private string? _name;
        public string? Name
        {
            get
            {
                // Logic
                if (_name != "No Name")
                {
                    return _name;
                }
                else
                {
                    return "No Name Entered Please ReEnter your name";
                }
            }
            set
            {
                // Logic
                _name = !string.IsNullOrEmpty(value) ? value : "No Name";
            }
        }
    
        // Smart Properties
        public int Age { get; /* set; */} = 25;
    }
    ```
    
    - Smart Properties: in C# you can create encapsulation properties in one line, if you not need a logic code to set or get that variable, you can just control of read and write of variable if you use smart properties to control it.
    
    ```csharp
    Person person = new Person();
    person.Name = "Medhat"; // Set
    Console.WriteLine(person.Name); // Get
    // person.Age = 25; //! Error Read only field.
    Console.WriteLine(person.Age);
    ```
    
    > **Advanced of Using Encapsulation :**
    > 
    > - Better control of class members
    > - Fields can be made read only, write only.
    > - Flexible: the programmer can change one part of the code without affecting other parts Increased security of data.
    
    ---
    
- **Polymorphism**
    
    means “**Many Forms**”, and it occurs when we have many classes that are related to each other by inheritance.
    
    it is useful for code reusability: reuse fields and methods of an existing class when you create a new class. 
    
    ```csharp
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
    
    ```
    
    ```csharp
    Monster lion = new Lion();
    lion.MakeSound();
    Monster tiger = new Tiger();
    tiger.MakeSound();
    
    Calculator c = new Calculator();
    Console.WriteLine(c.Add(2, 2));
    Console.WriteLine(c.Add(5, [2, 2, 1]));
    ```
    
    ---
    
- **Abstraction**
    
    is the process of hiding certain details and showing only essential information to the user.
    
    - it is not possible to create an object of abstract class.
    - to access abstract class, it must be inherited from another class.
    - using abstraction to achieve security in your code.
    
    ```csharp
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
    
    ```
    
    ```csharp
    ClothingShop clothingShop = new ClothingShop();
    clothingShop.Open();
    clothingShop.Close();
    EatingShop eatingShop = new EatingShop();
    eatingShop.Open();
    eatingShop.Close();
    ```
    
    ---
    
- **Method Hiding & Shadowing**
    - **Hiding Method**: it’s a concept of **Polymorphism,** but what if you want not to use the override method and want your object yo use base method from parent class And that what **Hiding Method** do.
        
        > When using hiding method, don’t use `override` keyword use `new` keyword.
        > 
        
        ```csharp
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
        ```
        
        ```csharp
        // Method Hiding
        Animal animal1 = new Animal();
        Animal cat1 = new Cat();
        // Cat animal2 = new Animal(); // Compilation error - cannot implicitly convert Animal to Cat
        Cat cat2 = new Cat();
        
        animal1.MakeSound(); // Output: "Animal makes a sound."
        cat1.MakeSound();    // Output: "Animal makes a sound." (hiding)
        cat2.MakeSound();    // Output: "Cat makes a sound."
        ```
        
    - **Shadowing Method:**  Same as Hiding Method but without using polymorphism it will just act like Hiding Method, this can lead to unexpected behavior as the base class method may still be invoked when calling the method on an object of the derived class.
        
        ```csharp
        public class Animal // Base Class
        {
            public void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }
        
        public class Cat : Animal // Child Class
        {
            public void MakeSound() 
            {
                Console.WriteLine("Cat makes a sound.");
            }
        }
        ```
        
        ```csharp
        // Method Hiding
        Animal animal1 = new Animal();
        Animal cat1 = new Cat();
        // Cat animal2 = new Animal(); // Compilation error - cannot implicitly convert Animal to Cat
        Cat cat2 = new Cat();
        
        animal1.MakeSound(); // Output: "Animal makes a sound."
        cat1.MakeSound();    // Output: "Animal makes a sound." (hiding)
        cat2.MakeSound();    // Output: "Cat makes a sound."
        ```