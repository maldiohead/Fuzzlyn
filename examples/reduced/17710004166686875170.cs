// Generated by Fuzzlyn on 2018-07-03 01:14:19
// Seed: 17710004166686875170
// Reduced from 101.9 KiB to 0.3 KiB
// Debug: Outputs 52374
// Release: Outputs -13162
public class Program
{
    public static void Main()
    {
        short[] vr2 = new short[]{0};
        long vr4 = -4925272163117052778L;
        vr2[0] = (short)vr4;
        char vr3 = (char)(vr2[0] | 0L);
        System.Console.WriteLine((int)vr3);
    }
}