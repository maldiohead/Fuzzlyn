// Generated by Fuzzlyn on 2018-07-13 15:09:35
// Seed: 17341119966604432374
// Reduced from 58.1 KiB to 0.2 KiB
// Debug: Outputs 4294967274
// Release: Outputs 234
public class Program
{
    static sbyte s_1 = -22;
    public static void Main()
    {
        var vr4 = (uint)s_1;
        ulong vr5 = vr4;
        System.Console.WriteLine(vr5);
    }
}