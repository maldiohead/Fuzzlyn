// Generated by Fuzzlyn on 2018-07-04 13:57:18
// Seed: 14742932420327105674
// Reduced from 44.3 KiB to 0.3 KiB
// Debug: Outputs 182
// Release: Outputs -74
struct S0
{
    public sbyte F2;
    public S0(sbyte f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S0 s_7 = new S0(-73);
    public static void Main()
    {
        var vr2 = (byte)(1L ^ s_7.F2);
        System.Console.WriteLine((int)vr2);
    }
}
