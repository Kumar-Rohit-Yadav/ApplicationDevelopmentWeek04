public class PercentageCalculator
{
    public void CalculatePercentage()
    {
        Console.WriteLine("\n--- Percentage Calculator ---");

        int marks = 0, total = 0;

        // Using TryParse for safe input
        Console.Write("Enter marks: ");
        while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0)
        {
            Console.Write("Invalid input. Please enter a positive integer for marks: ");
        }

        Console.Write("Enter total: ");
        while (!int.TryParse(Console.ReadLine(), out total) || total <= 0 || marks > total)
        {
            Console.Write("Invalid input. Please enter a positive integer for total (and ensure marks <= total): ");
        }

        // Breakpoint 1: Before calculation
        double percentage = (double)marks / total * 100;
        // Breakpoint 2: After calculation

        Console.WriteLine($"Percentage: {percentage:F2}%");
    }
}