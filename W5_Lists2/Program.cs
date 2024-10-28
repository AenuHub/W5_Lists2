public class Program
{
    public static void Main(string[] args)
    {
        List<string> coffeeNames = new List<string>();
        Console.WriteLine("Please enter 5 coffee names in order");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Coffee {i + 1}: ");
            string coffeeName = Console.ReadLine();
            coffeeNames.Add(coffeeName);
        }

        Console.WriteLine("--------------------------------");
        
        // Display the list of coffee names
        Console.WriteLine("The list of coffee names:");
        foreach (string coffeeName in coffeeNames)
        {
            Console.WriteLine(coffeeName);
        }
        
        Console.ReadKey();
    }
}