// Generated by Fuzzlyn on 2018-07-23 16:45:39
// Seed: 8892545038384943307
// Reduced from 104.5 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint[][, ] s_22 = new uint[][, ]{new uint[, ]{{0}}};
    public static void Main()
    {
        bool vr1 = 0 != ((0 % ((0 & s_22[0][0, 0]) | 1)) - s_22[0][0, 0]);
    }
}