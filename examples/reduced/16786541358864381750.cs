// Generated by Fuzzlyn on 2018-07-03 03:15:16
// Seed: 16786541358864381750
// Reduced from 49.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[,, ] s_2 = new byte[,, ]{{{0}}};
    static short[] s_6 = new short[]{0};
    public static void Main()
    {
        ulong vr1 = (ulong)((0 * s_6[0]) * s_2[0, 0, 0]);
        var vr2 = s_2[0, 0, 0];
        System.Console.WriteLine(vr1);
    }
}