// Generated by Fuzzlyn on 2018-07-16 06:09:55
// Seed: 12646791368804088794
// Reduced from 219.6 KiB to 0.2 KiB
// Debug: Outputs 65422
// Release: Outputs 4294967182
public class Program
{
    static ushort s_17;
    static sbyte s_87 = -114;
    public static void Main()
    {
        ushort vr2 = s_17;
        long vr3 = (char)(vr2 ^ s_87);
        System.Console.WriteLine(vr3);
    }
}