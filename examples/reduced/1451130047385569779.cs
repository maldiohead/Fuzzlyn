// Generated by Fuzzlyn on 2018-07-17 03:01:35
// Seed: 1451130047385569779
// Reduced from 275.5 KiB to 0.3 KiB
// Debug: Outputs 65430
// Release: Outputs 4294967190
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static uint s_2;
    static S0 s_3 = new S0(-105);
    public static void Main()
    {
        s_2 = (ushort)(-9223372036854775807L ^ s_3.F0);
        System.Console.WriteLine(s_2);
    }
}