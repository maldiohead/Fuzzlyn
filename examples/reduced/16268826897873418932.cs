// Generated by Fuzzlyn v1.1 on 2018-08-10 19:07:43
// Seed: 16268826897873418932
// Reduced from 1.6 KiB to 0.2 KiB
// Debug: Outputs -843707682
// Release: Outputs -661386530
public class Program
{
    static ushort[] s_1 = new ushort[]{0};
    static int s_2 = 661386530;
    public static void Main()
    {
        s_1[0] = 0;
        s_2 = (s_2 | s_1[0]--) * s_1[0];
        System.Console.WriteLine(s_2);
    }
}