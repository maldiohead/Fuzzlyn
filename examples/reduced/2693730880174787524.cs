// Generated by Fuzzlyn on 2018-07-10 13:18:38
// Seed: 2693730880174787524
// Reduced from 85.5 KiB to 0.2 KiB
// Debug: Outputs 202
// Release: Outputs -54
public class Program
{
    static sbyte s_1 = -54;
    static short s_5;
    public static void Main()
    {
        s_5 = (byte)(s_1 | 0L);
        System.Console.WriteLine(s_5);
    }
}