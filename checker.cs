using System;
using System.Diagnostics;

class Checker
{
    public static bool vitalsAreOk(float bpm, float spo2, float respRate)
    {
        return checkBpm(bpm) && checkSpo2(spo2) && checkRespRate(respRate);
        
    }
    static bool checkBpm(float bpm)
    {
        return (bpm >= 70 && bpm <= 150);
    }
    static bool checkSpo2(float spo2)
    {
        return (spo2 >= 90);
    }
    static bool checkRespRate(float respRate)
    {
        return (respRate >= 30 && respRate <= 95);
    }
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
    public static int Main(string[] args)
    {
        
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
