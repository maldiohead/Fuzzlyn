// Generated by Fuzzlyn on 2018-06-21 12:45:16
// Seed: 9638591694823938933
// Reduced from 296.6 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs -1
struct S0
{
    public char F1;
    public S0(char f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static sbyte s_2 = -128;
    public static void Main()
    {
        char vr21 = (char)(s_2 | 65535);
        S0 vr22 = new S0(vr21);
        System.Console.WriteLine((int)vr22.F1);
    }
}