// Generated by Fuzzlyn on 2018-07-14 15:38:38
// Seed: 18153962997935420008
// Reduced from 21.7 KiB to 0.4 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static bool s_1;
    public static void Main()
    {
        M5(65534);
    }

    static byte M5(ushort arg0)
    {
        var vr3 = (-9223372036854775808L % (-14873 | arg0)) & 0;
        M6(true, vr3);
        return (byte)'\'';
    }

    static bool M6(bool arg0, long arg1)
    {
        System.Console.WriteLine(arg0);
        return s_1;
    }
}