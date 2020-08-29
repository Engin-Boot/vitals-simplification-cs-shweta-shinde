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
}