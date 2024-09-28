## Debugging

### Debugging Mode

- **Set a breakpoint and start debugging**
    1. In the C# project, open Program.cs.
    2. Press F5, select the green arrow in the Visual Studio toolbar, or select Debug > Start Debugging to start debugging. The debugger pauses on the breakpoint that you set.

    ![Screenshot 2024-09-29 at 1 42 57 AM](https://github.com/user-attachments/assets/2997e02b-411a-49a8-ad26-834377e16592)


---

- **Principles of defensive programming**
    
    Writing robust and reliable code is paramount for all software developers. However, no matter how careful we are, bugs and unexpected situations can still occur. This is where defensive programming comes into play. Defensive programming is a coding practice aimed at ensuring that software functions correctly even when unexpected events or invalid inputs occur.
    
    1. **Validate Input**
        
        Always validate input data to ensure that it meets the expected criteria before processing it. This helps prevent runtime errors and ensures the stability of the application.
        
    2. **Handle Exceptions**
        
        Anticipate potential failure points in your code and use exception handling mechanisms such as try-catch blocks to gracefully handle errors and prevent crashes.
        
    3. **Fail Fast**
        
        Identify and report errors as soon as they occur rather than allowing them to propagate through the system. This helps in pinpointing issues early in the development process.
        
    4. **Use Assertions**
        
        Incorporate assertions into your code to enforce assumptions about the program’s state. Assertions can help detect logical errors early during development and testing phases.
        
    5. **Avoid Mutable State**
        
        Minimize the use of mutable state and prefer immutable data structures wherever possible (see also “[**Understanding Mutable and Immutable Types in C#**](https://medium.com/@jepozdemir/understanding-mutable-and-immutable-types-in-c-2c609fd75a12)”). This reduces the risk of unintended side effects and makes the code easier to reason about.
        
    6. **Encapsulate Complexity**
        
        Encapsulate complex logic and dependencies within well-defined modules or classes. This promotes modularity and reduces the likelihood of unintended interactions between different parts of the codebase.
        
    
    ---
    
- **Local/auto window**

The Autos window shows variables used around the current statement where the debugger is paused.

---

The Locals window **shows variables defined in the local scope, which is usually the current function or method**.

---

- **Watch window**
    
    While you're debugging, you can use **Watch** windows and **QuickWatch** to watch variables and expressions. The windows are only available during a debugging session.
    
    ![watch-variable](https://github.com/user-attachments/assets/5c03f35d-81a2-41a3-83ff-1aa7cd7f771d)
