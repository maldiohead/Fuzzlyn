// Generated by Fuzzlyn v1.1 on 2018-08-12 11:41:36
// Seed: 5142182243247843844
// Reduced from 33.1 KiB to 0.3 KiB
// Debug: Outputs -65535
// Release: Outputs 1
public class Program
{
    static long s_5 = 9223372036854775807L;
    static ulong s_9;
    public static void Main()
    {
        int vr13 = (int)(s_9 | (uint)(-1 * (ushort)M6()));
        System.Console.WriteLine(vr13);
    }

    static ref long M6()
    {
        return ref s_5;
    }
}