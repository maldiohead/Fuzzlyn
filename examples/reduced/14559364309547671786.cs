// Generated by Fuzzlyn on 2018-06-21 09:22:04
// Seed: 14559364309547671786
// Reduced from 45.1 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static ulong s_7 = 18446744073709551614UL;
    public static void Main()
    {
        sbyte vr8 = (sbyte)s_7;
        var vr7 = (ushort)vr8;
        uint vr10 = vr7;
        System.Console.WriteLine(vr10);
    }
}
