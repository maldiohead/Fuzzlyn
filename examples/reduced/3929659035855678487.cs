// Generated by Fuzzlyn v1.1 on 2018-08-03 22:21:25
// Seed: 3929659035855678487
// Reduced from 36.2 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[, ] s_17 = new ulong[, ]{{0}};
    public static void Main()
    {
        M9(ref s_17);
    }

    static sbyte M9(ref ulong[, ] arg0)
    {
        long var0 = 0 / (long)((0 & arg0[0, 0]) | 1);
        arg0[0, 0] = arg0[0, 0];
        return 0;
    }
}
