// Generated by Fuzzlyn on 2018-06-28 21:11:15
// Seed: 506605283101200065
// Reduced from 130.0 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_5 = new char[, ]{{'T'}};
    static sbyte s_9;
    public static void Main()
    {
        sbyte vr32 = (sbyte)(s_5[0, 0] & 0);
        char vr33 = s_5[0, 0];
        M29(vr32);
    }

    static sbyte M29(sbyte arg0)
    {
        return (sbyte)(16330 * s_9++);
    }
}