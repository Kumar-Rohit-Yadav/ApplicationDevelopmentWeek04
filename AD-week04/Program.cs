namespace AD_week04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object
            Student student1 = new Student();

            // Assign name to the student
            student1.Name = "Rohit";

            // Print the name
            Console.WriteLine($"Student name is: {student1.Name}");

        }
    }
}
