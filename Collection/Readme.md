## Collections

### Generics

- **Generics Definition**
    - Story: you have a client that want you display product (Name, Price) in application with integer price and string name, you accept and make this code
        
        ```csharp
        class Product{
        		string Name? {get; set;}
        		int Price {get; set;}
        		
        		public void ShowProduct(){
        				Console.WriteLine($"{Name}-{Price}");
        		}
        }
        
        public void Main(string[] args){
        
        	Product product = new Product()
        	{
        		Name = "P1",
        		Price = 20
        	}
        	product.ShowProduct();
        	
        }
        ```
        
        That good but then the client came back and ask to show the price in decimal format but keep the old formate as the same, you accept and do this
        
        ```csharp
        class Product{
        		string Name? {get; set;}
        		int Price {get; set;}
        		
        		public void ShowProduct(){
        				Console.WriteLine($"{Name}-{Price}");
        		}
        }
        
        class ProductWithDecimal{
        		string Name? {get; set;}
        		decimal Price {get; set;}
        		
        		public void ShowProduct(){
        				Console.WriteLine($"{Name}-{Price}");
        		}
        }
        
        public void Main(string[] args){
        
        	Product product = new Product()
        	{
        		Name = "P1",
        		Price = 20
        	}
        	product.ShowProduct();
        	
        	Product decimalProduct = new Product()
        	{
        		Name = "P1",
        		Price = 20.50
        	}
        	
        	decimalProduct.ShowProduct();
        }
        ```
        
        Thats perfect, then the client came back to make some change about name datatype to be integer ID, you said to him that will be infinity of classes of possible changes so the code will be non-readable and performance of app will be bad, and you lose your client 🥲
        

> Generic is declaring datatype of (class, method, fields, ..) at initialize it, so you can use different datatype with the same (class, method, fields, ..).
> 
- **Generics Class**
    - Now Lets use generics type with previous example
        
        ```csharp
        class Product<T, U>
        {
            public T? Name { get; set; }
            public U? Price { get; set; }
        
            public void ShowProduct()
            {
                Console.WriteLine($"{Name}-{Price}");
            }
        }
        ```
        
        ```csharp
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
        ```
        
        now you make all client possible change with just one class, with readable code, and better performance.
        
- **Generics Method**

```csharp
class Print<U>
{
    public U PrintText<T>(T text, U num)
    {
        Console.WriteLine(text);
        return num;
    }
}
```

```csharp
Print<int> print = new Print<int>();
print.PrintText/*<string>*/("Hello", 10);
```

- **Generics interface**
    
    ```csharp
    public interface IContainer<T>
    {
        void Add(T name);
    }
    
    public class Box<T> : IContainer<T>
    {
        public void Add(T name)
        {
            // Block of Code
        }
    }
    ```
    
- **Generics Constrains**
    
    you can set some constrains to your generics type to make sure other developer not use some type that make logic error on your code.
    
    ```csharp
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
    ```
    
    - `class` mean **Reference Type** only
    - `struct` mean **Value Type** only
    
    ```csharp
    Circle<string> circle = new Circle<string>();
    
    circle.Add("Medhat");
    
    //! Error Becuse T is Reference Type Only
    
    // Circle<int> circle = new Circle<int>();
    
    // circle.Add(10);
    ```
    
    > **you can add more than one constraint in the same generics type.**
    > 

---

### Collections in C#

- **Generics Collection**
    
    Collection you can use when you want all collection value to be same datatype, and that make some advantage in your code like:
    
    - High Performance.
    - Type-Safe coding.
    - Readability.
        - Example: Lists (Explained Before in Basic fundamental)
    
    ---
    
- **Non-Generics Collection**
    
    Collection you can use when you don’t care about datatype you just want to store data in some collection, but this collection make some disadvantage to your code like:
    
    - Low Performance.
    - Non Type-Safe coding.
    - Bad Readability.
    - Hard to get an error (Lot of logic error).
        - Example: ArrayLists
    
    ---
    
- **Array List**
    
    is non-generics collection type and its dynamic size so you not need to know size of your list at initializing, but its has no datatype define.
    
    Example:
    
    ```csharp
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
    ```
    
    - Boxing: Mean convert Value type to Reference type.
    - UnBoxing: Mean convert Reference type to Value type.
    
    > because of (Boxing and UnBoxing) Process in `arrayList` , it doesn’t need you to define datatype to it anymore because it will convert your value to object in initializing process, and convert object to value again at calling process.
    > 
    
    But like we said before it has disadvantage to use because its **Non-Generics Collection.**
    
    ---
    
- **Stack & Queue**
    - **Stack** is **Generics & Non-Generics Collection** you can use both of them but Generics s better, and its **Dynamic size**
        - Using **Last In First Out** process (**LIFO**)
            
            ![Screenshot 2024-10-08 at 8.01.37 AM.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/ac8d2e56-c643-48fc-af41-f14c17164785/f06819bb-2ec0-4815-84ed-93391886e2a6/Screenshot_2024-10-08_at_8.01.37_AM.png)
            
            Mean last value add to stack it will be first one to get out from the stack using `Push()` and `Pop()` Methods to make this action.
            
            ```csharp
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
            ```
            
        
        ---
        
    - **Queue** is **Generics & Non-Generics Collection** you can use both of them but Generics s better, and its **Dynamic size**
        - Using **First In First Out** process (**FIFO**)
            
            Mean First value add to queue it will be first one to get out from the queue using `Enqueue()` and `Dequeue()` Methods to make this action.
            
            ![Screenshot 2024-10-08 at 8.11.52 AM.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/ac8d2e56-c643-48fc-af41-f14c17164785/1ee76fc0-2215-43f1-8af0-00634bda0f0b/Screenshot_2024-10-08_at_8.11.52_AM.png)
            
            ```csharp
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
            ```
            
    
    ---
    
- **Tuple**
    
    its not collection but it more like build in class that you can stored data into it with different data type and its **Generics type, Reference value** but it have some properties you should follow it **(Max data you can store in it is 8 fields.)**
    
    > use tuple to return more than one value from function instead of (out , ref) parameters.
    > 
    
    ```csharp
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
    ```
    
    - **Value Tuple (Update of Tuple)**
        
        is like tuple but more easy to create and use, very light wight because it value type not reference type like `Tuple`.
        
        ```csharp
        ValueTuple<int, string, bool> person = (23, "Nor", true);
        Console.WriteLine(person.Item1); // 23
        Console.WriteLine(person.Item2); // Nor
        Console.WriteLine(person.Item3); // true
        
        // Other Way to create value tuple
        (string,string,int) car = ("Nissan" , "Hatshback" , 2009);
        Console.WriteLine(car.Item1); // Nissan
        Console.WriteLine(car.Item2); // Hatshback
        Console.WriteLine(car.Item3); // 2009
        ```
        
         **You can also name your fields in value type**
        
        ```csharp
        (string Model,string Type,int Year) car = ("Nissan" , "Hatshback" , 2009);
        Console.WriteLine(car.Model); // Nissan
        Console.WriteLine(car.Type); // Hatshback
        Console.WriteLine(car.Year); // 2009
        ```
        
        **Also it easier with creating and calling function**
        
        ```csharp
        (string Model, int Year) GetModelAndYear()
        {
            return ("Nissan", 2009);
        }
        
        (string CarModel, int CarYear) = GetModelAndYear();
        
        Console.WriteLine(CarModel);
        Console.WriteLine(CarYear);
        ```
        

---

### Key Value Per Collections

Stored data with unique key for each value like **Dictionary** (Explained before in Basics Fundamental).

- Using Example:
    - Setting.
    - Cashing.
    - Database (Light Wight).

---

- **Sorted List**
    
    **Generics Collection Type**, its like dictionary at everything but its **Sorted.** 
    
    ```csharp
    SortedList<int, string> sortedList = new SortedList<int, string>(){
    {2,"Medhat"} ,
    {1, "Ahmed"}
    };
    
    foreach (KeyValuePair<int, string> item in sortedList)
    {
        Console.WriteLine(item.Key);
        Console.WriteLine(item.Value);
    }
    
    ```
    
    ---
    
- **Hash Table**
    
    **Non-Generics Collections**, And absolute that return `DictionaryEntry` data type.
    
    ```csharp
    Hashtable hashtable = new Hashtable(){
    {10,"Product 1"} ,
    {"Boolean", false}
    };
    
    foreach (DictionaryEntry item in hashtable)
    {
        Console.Write(item.Key + ": ");
        Console.Write(item.Value + "\n");
    }
    ```
    

---

### Collection Internal

- **IEnumerable**
    
    All collections we talk about before **Implement** IEnumerable interface, IEnumerable allow `foreach` keyword to work with all this collections
    
    > IEnumerable hold all value of a list (array , stack , tuple , …) and in its contract have just one method called **GetEnumerator()** and this method return IEnumerator.
    > 
    
    let’s create new collection called **ShopList** that implement IEnumerable interface
    
    ```csharp
    public class ShopingList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    ```
    
    now as you can see ShopingList class have `GetEnumerator` method from IEnumerable interface and this method return an collection (List , Array , Stack ….).
    
- **IEnumerator**
    
    > IEnumerator is a (Person) who deal with all data in our list, it get the data from `GetEnumerator` method.
    > 
    
    now let’s create **ShopListEnumerator** for our ShopList.
    
    ```csharp
    public class ShopingListEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();
    
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    ```
    
    now as we can see IEnumerator implement three method
    
    - **Current**: Hold the start position of our list.
    - **MoveNext**: return true if the position move forward to next value successfully, and return false when it can’t get the next value of our list.
    - **Reset**: reset the position to start point when `foreach` finished the process.
    
    Let’s add some logic to our `ShopingListEnumerator` 
    
    ```csharp
    public class ShopingListEnumerator : IEnumerator
    {
        private string[] _items { get; set; }
        private int position = -1;
        public ShopingListEnumerator(string[] items)
        {
            _items = items;
        }
        public object Current
        {
            get
            {
                return _items[position];
            }
        }
    
        public bool MoveNext()
        {
            position++;
    
            if (position < _items.Length)
            {
    
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public void Reset()
        {
            position = -1;
        }
    }
    
    ```
    
    As we can see we create constructor to get our list from ShopingList class, create position variable to control the position of list, and set condition in MoveNext method to make sure our position will move correctly.
    
    return to ShopingList class, Let’s return our IEnumerator in `GetEnumerator` method.
    
    ```csharp
    public class ShopingList : IEnumerable
    {
        string[] items = new string[3] { "Bread", "Milk", "Beans" }; // My List
        
        public IEnumerator GetEnumerator()
        {
            return new ShopingListEnumerator(items);
        }
    }
    ```
    
    now we ready to test `foreach` method in our application with this new collection call **ShopingList.**
    
    ```csharp
    ShopingList shopingList = new ShopingList();
    
    foreach (var item in shopingList)
    {
        Console.WriteLine(item);
    }
    ```
    

> And This how all collection work in C# with deferent Logic but same way as they implement IEnumerable interface and using IEnumerator to deal with value.
> 

---

- **Indexer**
    
    in any collection you can get and set value in collection using index like this
    
    ```csharp
    List<int> list = new List<int>();
    
    list.Add(5); // Index 0
    list.Add(3); // Index 1
    list.Add(8); // Index 2
    
    Console.WriteLine(list[1]); // 3
    ```
    
    Now let’s go **Under the hood** to know how indexer work and create customs indexer
    
    - let’s create `Book` Class and `BookCollection` Class.

```csharp
public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
}

```

```csharp
public class BookCollection
{
    private Book[] books = new Book[5];
}
```

> **Main Goal is create object from BookCollection and use index to set & get Book Class info to our array in BookCollection Class**
> 

- Indexer is a normal properties with get and set but return the type of class you stored in collection array.
- Customs indexer useful when you need to add your logic to the collection because each collection you use has its own logic.
    
    ```csharp
    public class BookCollection
    {
        private Book[] books = new Book[5];
    
        public Book this[int Index]
        {
            get
            {
                return books[Index];
            }
            set
            {
                books[Index] = value;
            }
        }
    
    }
    ```
    
    ```csharp
    BookCollection bookCollection = new BookCollection();
    
    bookCollection[0] = new Book() { Title = "GOT", Author = "Robert" };
    bookCollection[1] = new Book() { Title = "Lord of the ring", Author = "Jon" };
    
    Console.WriteLine(bookCollection[0].Title);
    Console.WriteLine(bookCollection[0].Author);
    ```
    
- In customs indexer you can make indexer overloading to make your collection able to get or set with different datatype & value.
    
    ```csharp
    
    public class BookCollection
    {
        private Book[] books = new Book[5];
    
        public Book this[int Index]
        {
            get
            {
                return books[Index];
            }
            set
            {
                books[Index] = value;
            }
        }
    
        public Book this[string Title]
        {
            get
            {
                foreach (var book in books)
                {
                    if (book.Title == Title)
                    {
                        return book;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Title == Title)
                    {
                        books[i] = value;
                        return;
                    }
                }
    
                // Throw Exception if Not Found (Or Create new Book).
            }
        }
    
    }
    ```
    
    ```csharp
    BookCollection bookCollection = new BookCollection();
    
    bookCollection[0] = new Book() { Title = "GOT", Author = "Robert" };
    bookCollection[1] = new Book() { Title = "Lord of the ring", Author = "Jon" };
    
    Console.WriteLine(bookCollection["GOT"].Title);
    Console.WriteLine(bookCollection["Lord of the ring"].Author);
    ```