// Generated by Fuzzlyn on 2018-07-13 17:55:29
// Seed: 13940338252790527682
// Reduced from 40.7 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public char F7;
}

public class Program
{
    static C0[, ] s_4 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        int vr0 = 0 % (((s_4[0, 0].F7 & 0) - s_4[0, 0].F7) | 1);
    }
}