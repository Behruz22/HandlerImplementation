using HandlerProject;
using HandlerProject.Handlers;

class Program
{
    public static void Main(string[] args)
    {
        IHandler oneHundreHandler = new OneHundreHandler();
        IHandler fiftyHandler = new FiftyHandler();
        IHandler twentyHandler = new TwentyHandler();
        IHandler tenHandler = new TenHandler();
        IHandler fiveHandler = new FiveHandler();
        IHandler oneHundre = new OneHundreHandler();

        oneHundreHandler.MoveNext(fiftyHandler);
        fiftyHandler.MoveNext(twentyHandler);
        twentyHandler.MoveNext(tenHandler);
        tenHandler.MoveNext(fiveHandler);
        fiveHandler.MoveNext(oneHundre);

        Console.Write(">>> ");
        int amout = int.Parse(Console.ReadLine());
        string result = oneHundreHandler.Handler(amout);

        Console.WriteLine(result);


    }
}