// Generated by Fuzzlyn on 2018-07-12 06:20:51
// Seed: 18022039842382550752
// Reduced from 107.7 KiB to 0.2 KiB
// Debug: Outputs 4294967230
// Release: Outputs 190
public class Program
{
    static short s_6 = 1;
    static sbyte s_22 = -66;
    public static void Main()
    {
        sbyte vr8 = s_22;
        var vr9 = (uint)vr8 * s_6;
        System.Console.WriteLine(vr9);
    }
}