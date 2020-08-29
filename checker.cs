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
        bool low = bpm < 70;
        bool high = bpm > 150;
        if(low)
        {
            Console.WriteLine("BPM is LOW {0}",bpm);
            return false;
        }
        if(high)
        {
            Console.WriteLine("BPM is HIGH {0}",bpm);
            return false;
        }
        return true;
    }
    static bool checkSpo2(float spo2)
    {
        bool low= (spo2 < 90);
        if(low)
        {
            Console.WriteLine("SPO2 is LOW {0}",spo2);
        }
        return true;
    }
    static bool checkRespRate(float respRate)
    {
        bool low = (respRate < 30);
        bool high = (respRate > 95);
        if (low)
        {
            Console.WriteLine("RESP_RATE is LOW {0}", respRate);
            return false;
        }
        if (high)
        {
            Console.WriteLine("RESP_RATE is HIGH {0}", respRate);
            return false;
        }
        return true;

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
        IReporter reporter;
        reporter = new Reporter1();
        reporter.report(100, 95, 60);
        reporter.report(40, 91, 92);
        reporter = new Reporter2();
        reporter.report(100, 95, 60);
        reporter.report(40, 91, 92);
        /*ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");*/
        return 0;
    }
}
