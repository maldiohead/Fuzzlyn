// Generated by Fuzzlyn on 2018-07-03 06:47:31
// Seed: 8957220735173906504
// Reduced from 98.3 KiB to 0.3 KiB
// Debug: Outputs 241
// Release: Outputs -15
struct S0
{
    public sbyte F4;
    public S0(sbyte f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S0 s_29;
    public static void Main()
    {
        s_29 = new S0(-15);
        long vr52 = 0;
        var vr46 = (byte)(vr52 ^ s_29.F4);
        System.Console.WriteLine((int)vr46);
    }
}