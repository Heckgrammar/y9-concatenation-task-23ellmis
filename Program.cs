namespace Y9ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string FirstName;
        Console.Write("Enter first name: ");
        FirstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string LastName = Console.ReadLine();
        Console.Write("Enter your age: ");
         string Age = Console.ReadLine();
         Console.WriteLine("Hello " + FirstName + " " + LastName  + " you are " + Age + " years old");
        }
    }
}
