// Generated by Fuzzlyn on 2018-07-30 04:07:34
// Seed: 11995846995024541985
// Reduced from 39.7 KiB to 0.3 KiB
// Debug: Outputs True
// Release: Outputs False
public class Program
{
    static bool[][] s_12 = new bool[][]{new bool[]{false}};
    static byte s_16;
    static bool[] s_18;
    static sbyte s_22 = -98;
    public static void Main()
    {
        s_18 = s_12[0];
        bool vr15 = (char)(s_22 ^ 0L) > s_16;
        s_18[0] = vr15;
        System.Console.WriteLine(s_12[0][0]);
    }
}
