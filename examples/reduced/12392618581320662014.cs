// Generated by Fuzzlyn on 2018-07-31 02:16:27
// Seed: 12392618581320662014
// Reduced from 9.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[][][, ] s_1 = new short[][][, ]{new short[][, ]{new short[, ]{{0}}}};
    public static void Main()
    {
        bool vr5 = (-21067837 + (0 & s_1[0][0][0, 0])) < 0;
        if (vr5)
        {
            s_1[0][0] = new short[, ]{{0}};
        }
    }
}
