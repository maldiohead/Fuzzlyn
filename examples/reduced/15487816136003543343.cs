// Generated by Fuzzlyn on 2018-06-24 06:19:18
// Seed: 15487816136003543343
// Reduced from 203.0 KiB to 0.3 KiB
// Debug: Outputs 65475
// Release: Outputs -61
public class Program
{
    static short s_8;
    static sbyte s_14 = -61;
    public static void Main()
    {
        char vr29 = (char)M97();
        System.Console.WriteLine((int)vr29);
    }

    static ushort M97()
    {
        return (ushort)(s_14 | s_8);
    }
}