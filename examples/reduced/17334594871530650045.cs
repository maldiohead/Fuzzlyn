// Generated by Fuzzlyn on 2018-07-30 22:56:21
// Seed: 17334594871530650045
// Reduced from 3.2 KiB to 0.2 KiB
// Debug: Outputs 65494
// Release: Outputs -42
public class Program
{
    public static void Main()
    {
        var vr6 = new sbyte[]{-42};
        int vr8 = (char)(vr6[0] ^ -9223372036854775808L);
        System.Console.WriteLine(vr8);
    }
}