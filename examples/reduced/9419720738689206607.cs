// Generated by Fuzzlyn on 2018-07-28 21:34:24
// Seed: 9419720738689206607
// Reduced from 274.4 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte s_2;
    static int s_3;
    static uint[, ] s_13 = new uint[, ]{{0}};
    public static void Main()
    {
        var vr36 = s_13[0, 0] & 0;
        var vr37 = s_13[0, 0];
        M15(vr36);
    }

    static int M15(ulong arg1)
    {
        arg1 = (ulong)(s_2 - -10091);
        return s_3;
    }
}