## <span style="color:#87CEEB; font-weight:bold;">Practical Exercises C#</span>

**- Exercise 1: <span style="color:#FFD700;">The Greeting</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to C# Programming!");
    }
}
```
**- Exercise 2: <span style="color:#FFD700;">Personal Info</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        string name = "MrFall";
        int age = 20;

        Console.WriteLine("My name is " + name + " and I am " + age + " years old.");
    }
}
```

**- Exercise 3: <span style="color:#FFD700;">The Calculator</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 5;
        int sum = num1 + num2;

        Console.WriteLine("The sum is: " + sum);
    }
}
```

**- Exercise 4: <span style="color:#FFD700;">The Bouncer (If/Else)</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        int userAge = 16;

        if (userAge >= 18)
        {
            Console.WriteLine("Access Granted.");
        }
        else
        {
            Console.WriteLine("Access Denied.");
        }
    }
}
```

**- Exercise 5: <span style="color:#FFD700;">The Countdown (Loops)</span>Task :**
```
using System;

class Program
{
    static void Main()
    {
        int count = 10;

        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }

        Console.WriteLine("Liftoff!");
    }
}
```

**- Exercise 6: <span style="color:#FFD700;">The Repeater (Functions)</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        SayHello("Adam");
        SayHello("Sara");
        SayHello("John");
    }

    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}
```

**- Exercise 7: <span style="color:#FFD700;">Even or Odd?</span> Task :**
```
using System;

class Program
{
    static void Main()
    {
        for (int number = 1; number <= 10; number++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Number " + number + " is Even");
            }
            else
            {
                Console.WriteLine("Number " + number + " is Odd");
            }
        }
    }
}
```