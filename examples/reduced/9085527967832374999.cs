// Generated by Fuzzlyn on 2018-07-06 13:10:39
// Seed: 9085527967832374999
// Reduced from 130.7 KiB to 0.2 KiB
// Debug: Outputs 37323
// Release: Outputs -28213
public class Program
{
    static short s_1 = -28214;
    public static void Main()
    {
        char vr10 = (char)(s_1 | 1U);
        System.Console.WriteLine((int)vr10);
    }
}