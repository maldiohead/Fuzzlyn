// Generated by Fuzzlyn on 2018-06-27 20:14:19
// Seed: 11517619871843462870
// Reduced from 55.3 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong s_11;
    static bool[,, ][] s_15 = new bool[,, ][]{{{new bool[]{false}}}};
    public static void Main()
    {
        var vr5 = new uint[][, ]{new uint[, ]{{0}}};
        M3(vr5, s_11);
    }

    static bool[] M3(uint[][, ] arg0, ulong arg2)
    {
        arg2 = ((arg2 / ((arg0[0][0, 0] & 0) | 1)) | arg0[0][0, 0]);
        return s_15[0, 0, 0];
    }
}
