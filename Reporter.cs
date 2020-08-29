using System;
interface IReporter
{
    void report(float bpm, float spo2, float respRate);
}
class Reporter1 : IReporter
{
    public void report(float bpm,float spo2,float respRate)
    {
        Console.WriteLine("Reporter-1");
        bool status = Checker.vitalsAreOk(bpm, spo2, respRate);
        if (status)
            Console.WriteLine("All Vitals OK");
    }
}
class Reporter2 : IReporter
{
    public void report(float bpm, float spo2, float respRate)
    {
        Console.WriteLine("Reporter-2");
        bool status = Checker.vitalsAreOk(bpm, spo2, respRate);
        if (status)
            Console.WriteLine("All Vitals OK");
    }
}