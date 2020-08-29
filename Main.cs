using System;
class MainClass
{
    static void ExpectTrue(bool expression)
    {
        if (!expression)
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main(string[] args)
    {
        
        ExpectTrue(Checker.vitalsAreOk(100, 95, 60));
        ExpectFalse(Checker.vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}