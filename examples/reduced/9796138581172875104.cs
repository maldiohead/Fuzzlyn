// Generated by Fuzzlyn on 2018-06-22 07:24:45
// Seed: 9796138581172875104
// Reduced from 94.1 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs -32767
public class Program
{
    static short s_2 = -32767;
    public static void Main()
    {
        char vr22 = (char)(s_2 / 1U);
        System.Console.WriteLine((int)vr22);
    }
}