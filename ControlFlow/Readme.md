## Control Flow

### Conditional Statement

specify a block of C# code to be executed if a condition is true.

- Conditions

| Condition | Symbol | Example |
| --- | --- | --- |
| Less Than | < | `x < y` |
| Less Than Or Equal | <= | `x <= y` |
| Greater Than | > | `x > y` |
| Greater Than Or Equal | >= | `x >= y` |
| Equal To | == | `x == y` |
| Not Equal To | != | `x != y` |
- Multiply Conditions

| Definitions | Symbol | Rule |
| --- | --- | --- |
| AND (Executable while condition not success) | && | `true && true` |
| OR (Executable while condition not success) | || | `true || false`  or `flase || true` |
| NOT | ! | `!true = false` or `!false = true` |
| XOR | ^ | `true ^ true = false` 
`true ^ false = true` 
`false ^ true = true` 
`false ^ false = false` |
| AND (Executable All Condition) | & | `false & true` |
| OR (Executable All Condition) | | | `true | false` |
1. **If Statement**

```csharp
int x = 10, y = 20;
if (x < y)
{
    Console.WriteLine($"x:{x} is less than y:{y}");
}
else if (x == y)
{
    Console.WriteLine($"x:{x} is equal y:{y}");
}
else
{
    Console.WriteLine($"x:{x} is grater than y:{y}");
}
```

1. Switch Statement

```csharp
int x = 2;

switch (x)
{
    case 2:
        Console.WriteLine("x = 2");
        break;
    case 5:
        Console.WriteLine("x = 5");
        break;
    case 10:
        Console.WriteLine("x = 10");
        break;
    default:
        {
            Console.WriteLine("No Conditon Role Success");
            break;
        }

}
```

### Loop Statements

- **For Loop:** When you know exactly how many times you want to loop through a block of code.

```csharp
for (int i = 0; i < 20; i++)
{
    Console.WriteLine(i);
}
```

- **While Loop:** Loops can executed a block of code. as long as a specified condition is true.

```csharp
int j = 10;
while (j != 0)
{
    Console.WriteLine(j);
    j--;
}
```

- **Do While Loop:** This loop will execute the code block once, before checking if condition is true or not.

```csharp
do
{
    Console.WriteLine(2);
} while (3 > 4);

```