namespace HW4_Module2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Zoo!");
            Zoo zoo = new Zoo();
            zoo.ShowAllAnimals();
            zoo.ShowPredator();
            zoo.FindAnimal();
        }
    }
}