namespace VariablesExercise
{
    public class Program
    {
        


        static void Main(string[] args)
        {
        string name = "Michael";
        int age = 26;
        char middleInitial = 'J';
        bool isOver18 = true;
        double currentTemp = 72.5;
        decimal currentHeight = 6.0m;


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Height: {currentHeight}ft");
        }
    }
}
