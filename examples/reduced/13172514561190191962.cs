// Generated by Fuzzlyn on 2018-06-26 08:51:07
// Seed: 13172514561190191962
// Reduced from 18.7 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
class C0
{
    public sbyte F2;
}

public class Program
{
    static short s_3;
    public static void Main()
    {
        var vr7 = new C0();
        sbyte vr12 = vr7.F2;
        bool vr8 = (0 / (-580695068 | ((-9223372036854775808L / (int)(9223372036854775807L | vr12)) & 0))) < s_3;
    }
}