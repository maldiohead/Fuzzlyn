// Generated by Fuzzlyn on 2018-07-27 12:00:20
// Seed: 10484539402191636615
// Reduced from 31.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ulong F7;
    public ushort F8;
}

struct S0
{
    public C0 F0;
    public S0(C0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_6 = new S0(new C0());
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        byte vr3 = (byte)(s_6.F0.F8 / ((s_6.F0.F7 - s_6.F0.F7) | 1));
    }
}