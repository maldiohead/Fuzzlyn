// Generated by Fuzzlyn on 2018-06-28 23:55:41
// Seed: 12904797108591525553
// Reduced from 17.5 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[][, ] s_3 = new char[][, ]{new char[, ]{{'m'}}};
    public static void Main()
    {
        bool vr2 = (s_3[0][0, 0] & 0) <= 0;
        if (vr2)
        {
            var vr3 = s_3[0][0, 0];
        }
        else
        {
        }
    }
}