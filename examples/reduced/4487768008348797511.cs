// Generated by Fuzzlyn on 2018-07-03 03:34:53
// Seed: 4487768008348797511
// Reduced from 86.2 KiB to 0.5 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
class C0
{
}

public class Program
{
    static ushort s_1;
    static ulong[] s_2;
    public static void Main()
    {
        var vr10 = new ushort[][, ]{new ushort[, ]{{0}}};
        M10(vr10);
    }

    static uint M10(ushort[][, ] arg0)
    {
        s_1 = (ushort)(0 & arg0[0][0, 0]);
        arg0[0][0, 0] = arg0[0][0, 0];
        C0 vr4 = new C0();
        return M14(s_2, vr4);
    }

    static ushort M14(ulong[] arg0, C0 arg2)
    {
        return 0;
    }
}