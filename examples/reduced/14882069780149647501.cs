// Generated by Fuzzlyn on 2018-06-23 21:40:23
// Seed: 14882069780149647501
// Reduced from 69.5 KiB to 0.2 KiB
// Debug: Outputs 65496
// Release: Outputs -40
public class Program
{
    static sbyte s_4 = -40;
    static short s_23;
    public static void Main()
    {
        short vr2 = s_23;
        char vr1 = (char)(vr2 | s_4);
        System.Console.WriteLine((int)vr1);
    }
}