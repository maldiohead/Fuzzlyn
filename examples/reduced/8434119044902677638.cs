// Generated by Fuzzlyn on 2018-06-26 06:29:12
// Seed: 8434119044902677638
// Reduced from 12.7 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public byte F3;
    public uint F7;
}

public class Program
{
    static S0[, ] s_1 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        var vr18 = 10 | (0 & s_1[0, 0].F3);
        var vr19 = s_1[0, 0];
        ushort vr22 = (ushort)(vr19.F7 % vr18);
    }
}