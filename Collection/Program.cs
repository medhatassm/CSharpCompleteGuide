using Collection.Models;
using System.Collections;

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

#region ArrayList

// Normal Array
int[] arr = new int[3] { 1, 4, 9 }; // Fixed Size

// Array List (non type-safe)
ArrayList arrayList = new ArrayList(); // Dynamic Object


arrayList.Add("String in Array List"); // Boxing
arrayList.Add(5);
arrayList.Add(10);
arrayList.Add(15);

Console.Write(arrayList[0]); // Unboxing
arrayList.Remove(10);
arrayList.RemoveAt(2);

arrayList.AddRange(arr);

arrayList.Insert(1, "This is Insert Method");

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

#endregion

#region Sorted List

SortedList<int, string> sortedList = new SortedList<int, string>(){
{2,"Medhat"} ,
{1, "Ahmed"}
};

foreach (KeyValuePair<int, string> item in sortedList)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}

#endregion

#region Hashtable

Hashtable hashtable = new Hashtable(){
{10,"Product 1"} ,
{"Boolean", false}
};

foreach (DictionaryEntry item in hashtable)
{
    Console.Write(item.Key + ": ");
    Console.Write(item.Value + "\n");
}

#endregion

#region Stack

Stack<int> stack = new Stack<int>(/* Array */); // Last in First out (LIFO)

stack.Push(5);
stack.Push(3);
stack.Push(9);
// stack.Push("Text");

Console.WriteLine(stack.Pop()); // 9
Console.WriteLine(stack.Pop()); // 3

foreach (var item in stack)
{
    Console.WriteLine(item); // 5 becuse size decrement when we call Pop Function.
}

#endregion

#region Queue

Queue<int> queue = new Queue<int>(/* Array */); // First In First Out

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

Console.WriteLine(queue.Dequeue()); // 1
Console.WriteLine(queue.Dequeue()); // 2
Console.WriteLine(queue.Dequeue()); // 3

foreach (var item in queue)
{
    Console.WriteLine(item); // 4 becuse size decrement when we call Dequeue Function.
}


#endregion

#region Tuple

Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(24, "Medhat", false);

Console.WriteLine(tuple.Item1); // 24
Console.WriteLine(tuple.Item2); // Medhat
Console.WriteLine(tuple.Item3); // false

var Employee1 = Tuple.Create(24, "Employee1", true, 6000.00, false, 12, "Prgramming", Tuple.Create("Marim", "Ali", 1));

Console.WriteLine(Employee1.Rest.Item1.Item2); // Ali

// Using Tuple As Function

Tuple<string, int> GetNameAndAge()
{
    return Tuple.Create("Medhat", 25);
}

Console.WriteLine(GetNameAndAge().Item1);
Console.WriteLine(GetNameAndAge().Item2);

// Value Tuple
ValueTuple<int, string, bool> person = (23, "Nor", true);
Console.WriteLine(person.Item1); // 23
Console.WriteLine(person.Item2); // Nor
Console.WriteLine(person.Item3); // true

(string Model, string Type, int Year) car = ("Nissan", "Hatshback", 2009);
Console.WriteLine(car.Model); // Nissan
Console.WriteLine(car.Type); // Hatshback
Console.WriteLine(car.Year); // 2009

// Value Tuple with function
(string Model, int Year) GetModelAndYear()
{
    return ("Nissan", 2009);
}

(string CarModel, int CarYear) = GetModelAndYear();

Console.WriteLine(CarModel);
Console.WriteLine(CarYear);

#endregion

#region IEnumarable

ShopingList shopingList = new ShopingList();

foreach (var item in shopingList)
{
    Console.WriteLine(item);
}

#endregion

#region Indexer

BookCollection bookCollection = new BookCollection();

bookCollection[0] = new Book() { Title = "GOT", Author = "Robert" };
bookCollection[1] = new Book() { Title = "Lord of the ring", Author = "Jon" };

Console.WriteLine(bookCollection["GOT"].Title);
Console.WriteLine(bookCollection["Lord of the ring"].Author);

#endregion



