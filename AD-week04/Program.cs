using System;

class Program
{
    static void Main()
    {
        // Task 1: Class, Object & Fields
        Console.WriteLine("=== Task 1: Student Class ===");
        Student student1 = new Student();
        Student student2 = new Student();

        student1.Name = "John Doe";
        student1.Age = 20;
        student1.Course = "Computer Science";

        student2.Name = "Jane Smith";
        student2.Age = 22;
        student2.Course = "Mathematics";

        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Course: {student1.Course}");

        Console.WriteLine("\nStudent 2:");
        Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Course: {student2.Course}");

        Console.WriteLine($"\nSchool: {Student.SchoolName}");

        // Task 2: Methods & Return Types
        Console.WriteLine("\n=== Task 2: Calculator Class ===");
        Calculator calc = new Calculator();
        calc.PrintWelcome();

        int sum = calc.Add(5, 3);
        Console.WriteLine($"Addition: 5 + 3 = {sum}");

        int product1 = calc.Multiply(4, 5);
        int product2 = calc.Multiply(7);
        Console.WriteLine($"Multiplication: 4 * 5 = {product1}");
        Console.WriteLine($"Multiplication: 7 * 1 = {product2}");

        // Task 3: Parameter Types
        Console.WriteLine("\n=== Task 3: ParameterDemo Class ===");
        ParameterDemo demo = new ParameterDemo();

        int number = 5;
        Console.WriteLine($"Original number: {number}");
        demo.Increase(ref number);
        Console.WriteLine($"After Increase: {number}");

        demo.GetFullName(out string fullName);
        Console.WriteLine($"Full Name: {fullName}");

        int sum1 = demo.SumAll(1, 2, 3);
        int sum2 = demo.SumAll(10, 20, 30, 40, 50);
        Console.WriteLine($"Sum 1: {sum1}");
        Console.WriteLine($"Sum 2: {sum2}");

        // Task 4: Constructors
        Console.WriteLine("\n=== Task 4: Player Class ===");
        Player player1 = new Player();
        Player player2 = new Player("Warrior", 10, 100);

        Console.WriteLine("\nPlayer 1 (Default):");
        Console.WriteLine($"Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");

        Console.WriteLine("\nPlayer 2 (Parameterized):");
        Console.WriteLine($"Name: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");

        // Task 5: Enums and Records
        Console.WriteLine("\n=== Task 5: Enums and Records ===");
        Console.Write("Enter a day (e.g., Sunday): ");
        string dayInput = Console.ReadLine();

        if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It is: Weekend");
        }
        else
        {
            Console.WriteLine("It is: Weekday");
        }

        Book book1 = new Book("C# Programming", "John Doe", 29.99);
        Book book2 = book1 with { Title = "Advanced C#", Price = 39.99 };

        Console.WriteLine($"\nBook 1: {book1}");

        var (title, author, price) = book2;
        Console.WriteLine($"Book 2 - Title: {title}, Author: {author}, Price: {price}");

        // Task 6: Debugging
        Console.WriteLine("\n=== Task 6: Debugging ===");
        PercentageCalculator percentageCalc = new PercentageCalculator();
        percentageCalc.CalculatePercentage();

        // Task 7: Research Activity
        Console.WriteLine("\n=== Task 7: Research Activity ===");
        Console.WriteLine("Research on Constructors:");
        Console.WriteLine("Constructors help in software development by:");
        Console.WriteLine("1. Ensuring objects are properly initialized before use");
        Console.WriteLine("2. Improving code reliability by enforcing required parameters");
        Console.WriteLine("3. Making code more maintainable through consistent object creation");
        Console.WriteLine("\nReal-world use cases:");
        Console.WriteLine("1. Database connections - constructor sets up connection parameters");
        Console.WriteLine("2. User authentication - constructor validates credentials");
        Console.WriteLine("3. Financial transactions - constructor ensures all required data is present");

        Console.WriteLine("\nResearch Resources:");
        Console.WriteLine("- Microsoft C# Documentation");
        Console.WriteLine("- Stack Overflow");
        Console.WriteLine("- GeeksforGeeks");
    }
}