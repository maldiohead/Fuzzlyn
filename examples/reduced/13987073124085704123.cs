// Generated by Fuzzlyn on 2018-07-21 00:32:24
// Seed: 13987073124085704123
// Reduced from 64.1 KiB to 0.3 KiB
// Debug: Outputs 65533
// Release: Outputs 4294967293
class C0
{
    public long F8;
}

public class Program
{
    static sbyte s_2 = -3;
    public static void Main()
    {
        C0[][][] vr9 = new C0[][][]{new C0[][]{new C0[]{new C0()}}};
        vr9[0][0][0].F8 = (char)(s_2 | 1U);
        System.Console.WriteLine(vr9[0][0][0].F8);
    }
}
