// Generated by Fuzzlyn on 2018-07-05 13:04:53
// Seed: 12561841347626014422
// Reduced from 171.4 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static short[][][][] s_8 = new short[][][][]{new short[][][]{new short[][]{new short[]{-2}}}};
    static short s_46;
    public static void Main()
    {
        s_46 = s_8[0][0][0][0];
        var vr16 = (char)(s_46 / (uint)1);
        uint vr17 = vr16;
        System.Console.WriteLine(vr17);
    }
}