// Generated by Fuzzlyn on 2018-07-25 10:05:36
// Seed: 9323975381128293542
// Reduced from 5.1 KiB to 0.4 KiB
// Debug: Outputs 1
// Release: Outputs 2
public class Program
{
    static ushort s_1;
    static long s_2;
    public static void Main()
    {
        ++s_1;
        byte vr8 = 0;
        s_2 -= ((vr8 * M1()) & s_1);
        ++s_1;
        System.Console.WriteLine(s_1);
    }

    static short M1()
    {
        short var0 = default(short);
        s_1 = 0;
        System.Console.WriteLine(var0);
        return 0;
    }
}
