// Generated by Fuzzlyn v1.1 on 2018-08-10 16:12:11
// Seed: 1028050178271219033
// Reduced from 334.8 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static sbyte[] s_34 = new sbyte[]{-1};
    public static void Main()
    {
        var vr53 = (ushort)(s_34[0] ^ 1U);
        ulong vr54 = vr53;
        System.Console.WriteLine(vr54);
    }
}