// Generated by Fuzzlyn on 2018-07-11 17:52:47
// Seed: 2473309561596451443
// Reduced from 42.9 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public byte F0;
    public byte F2;
}

public class Program
{
    static S0[, ] s_1 = new S0[, ]{{new S0()}};
    public static void Main()
    {
        bool vr5 = 8583251472287427228UL != (s_1[0, 0].F0 & 0U);
        if (vr5)
        {
            var vr6 = s_1[0, 0].F2;
        }
    }
}