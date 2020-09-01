using System;
using System.Diagnostics;

class Checker
{
    public static bool vitalsAreOk(float bpm, float spo2, float respRate)
    {
        bool bool_bpm, bool_spo2, bool_respRate;
        bool_bpm = checkRange(70, 150, bpm, "BPM");
        bool_spo2 = checkRange(90, 250, spo2, "SPO2");
        bool_respRate = checkRange(30, 95, respRate, "RESP_RATE");
        bool status = bool_bpm && bool_spo2 && bool_respRate;
        return status;

    }

    static bool checkRange(float low_limit, float high_limit, float vital, string vitalType)
    {
        bool low = vital < low_limit;
        bool high = vital > high_limit;
        if (low)
        {
            Console.WriteLine("{0} is LOW {1}",vitalType,vital);
            return false;
        }
        if (high)
        {
            Console.WriteLine("{0} is HIGH {1}", vitalType, vital);
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
