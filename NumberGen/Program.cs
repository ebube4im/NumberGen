namespace NumberGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generator Begins");
            Generator gen = new Generator();
            gen.Run();
        }
    }
}