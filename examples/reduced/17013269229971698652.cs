// Generated by Fuzzlyn on 2018-07-30 23:19:46
// Seed: 17013269229971698652
// Reduced from 139.4 KiB to 0.2 KiB
// Debug: Outputs 65429
// Release: Outputs 4294967189
public class Program
{
    static sbyte s_1 = -108;
    public static void Main()
    {
        var vr11 = (ushort)(s_1 ^ 1U);
        uint vr12 = vr11;
        System.Console.WriteLine(vr12);
    }
}
