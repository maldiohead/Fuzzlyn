// Generated by Fuzzlyn on 2018-07-07 21:57:10
// Seed: 2634276031146253568
// Reduced from 386.5 KiB to 0.3 KiB
// Debug: Outputs 65409
// Release: Outputs 4294967169
public class Program
{
    static char s_26;
    static ulong s_59;
    static sbyte[, ][] s_60 = new sbyte[, ][]{{new sbyte[]{-127}}};
    public static void Main()
    {
        s_59 = (ushort)(s_26 ^ s_60[0, 0][0]);
        System.Console.WriteLine(s_59);
    }
}