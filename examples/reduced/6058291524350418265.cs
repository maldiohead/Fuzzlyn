// Generated by Fuzzlyn on 2018-07-05 07:54:11
// Seed: 6058291524350418265
// Reduced from 13.7 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static ushort s_1 = 1;
    static int s_3;
    public static void Main()
    {
        long vr10 = (char)(0 | (ulong)(-1 * s_1));
        s_3 = (int)vr10;
        System.Console.WriteLine(s_3);
    }
}
