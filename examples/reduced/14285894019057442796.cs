// Generated by Fuzzlyn on 2018-07-07 14:51:20
// Seed: 14285894019057442796
// Reduced from 84.3 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public sbyte F2;
}

public class Program
{
    static uint[, ][, ] s_1 = new uint[, ][, ]{{new uint[, ]{{1U}}}};
    static C0 s_2 = new C0();
    public static void Main()
    {
        s_2.F2 /= (sbyte)(((0 & s_1[0, 0][0, 0]) / s_1[0, 0][0, 0]) | 1);
    }
}