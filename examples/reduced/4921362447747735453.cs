// Generated by Fuzzlyn on 2018-06-23 01:41:11
// Seed: 4921362447747735453
// Reduced from 5.4 KiB to 0.2 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    public static void Main()
    {
        var vr2 = new int[]{0};
        var vr3 = new sbyte[, ]{{-1}};
        ulong vr6 = (char)(vr3[0, 0] ^ vr2[0]);
        System.Console.WriteLine(vr6);
    }
}