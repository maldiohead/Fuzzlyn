// Generated by Fuzzlyn on 2018-07-14 04:09:07
// Seed: 13262627118214669592
// Reduced from 20.0 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public ushort F0;
}

public class Program
{
    static ulong[,, ] s_1 = new ulong[,, ]{{{0}}};
    static S0 s_6;
    public static void Main()
    {
        var vr22 = (ushort)(0 & s_1[0, 0, 0]);
        var vr23 = s_6.F0;
        ushort vr24 = vr23;
        M2(vr22, false);
    }

    static bool M2(ushort arg3, bool arg5)
    {
        uint[] var0 = new uint[]{1180524983U, 1U};
        return arg5;
    }
}
