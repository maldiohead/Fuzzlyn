// Generated by Fuzzlyn on 2018-06-28 08:39:22
// Seed: 10213520807816009654
// Reduced from 283.5 KiB to 0.2 KiB
// Debug: Outputs 32769
// Release: Outputs 4294934529
public class Program
{
    static short s_17;
    public static void Main()
    {
        s_17 = -32767;
        ushort vr25 = (ushort)(s_17 | (long)0);
        ulong vr27 = vr25;
        System.Console.WriteLine(vr27);
    }
}