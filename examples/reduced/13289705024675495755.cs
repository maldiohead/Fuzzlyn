// Generated by Fuzzlyn on 2018-07-08 09:33:24
// Seed: 13289705024675495755
// Reduced from 2.0 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static ulong s_1 = 18446744073709551615UL;
    public static void Main()
    {
        char vr0 = (char)(sbyte)(s_1 ^ 0);
        System.Console.WriteLine((int)vr0);
    }
}