namespace simpleGit;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello Git!");
        Console.WriteLine(DoSomething("Alfred"));
        Console.WriteLine("Nisse was here");
    }


    static string DoSomething(string name)
    {
        return $"Hello {name}";
    }
}
