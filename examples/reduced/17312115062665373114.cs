// Generated by Fuzzlyn on 2018-06-24 22:35:37
// Seed: 17312115062665373114
// Reduced from 7.9 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S1
{
    public uint F0;
    public S1(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static char[][, ] s_1 = new char[][, ]{new char[, ]{{'Z'}}};
    public static void Main()
    {
        var vr4 = new S1((uint)(0 & s_1[0][0, 0]));
        var vr5 = s_1[0][0, 0];
        s_1 = M1(vr4);
    }

    static char[][, ] M1(S1 arg3)
    {
        return new char[][, ]{new char[, ]{{'7'}}};
    }
}
