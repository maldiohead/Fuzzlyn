// Generated by Fuzzlyn on 2018-07-10 08:26:16
// Seed: 138909677023893180
// Reduced from 44.8 KiB to 0.4 KiB
// Debug: Outputs 4294967295
// Release: Outputs 65535
struct S2
{
    public int F0;
    public sbyte F1;
    public sbyte F3;
    public S2(sbyte f3): this()
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        S2 vr13 = new S2(-1);
        vr13.F1 = vr13.F3;
        long vr14 = (char)(vr13.F1 ^ vr13.F0);
        System.Console.WriteLine(vr14);
    }
}