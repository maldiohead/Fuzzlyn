// Generated by Fuzzlyn v1.1 on 2018-08-03 04:38:38
// Seed: 2123645869371283159
// Reduced from 123.7 KiB to 0.3 KiB
// Debug: Outputs 18446744069414584331
// Release: Outputs 18446744073709551371
class C2
{
    public short F0;
    public C2(short f0)
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        var vr22 = new C2(-19703);
        ref short vr33 = ref vr22.F0;
        var vr25 = 2UL - (uint)(4294967295U * (sbyte)vr33);
        System.Console.WriteLine(vr25);
    }
}
