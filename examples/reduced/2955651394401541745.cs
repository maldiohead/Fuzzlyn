// Generated by Fuzzlyn on 2018-07-19 15:17:07
// Seed: 2955651394401541745
// Reduced from 7.9 KiB to 0.4 KiB
// Debug: Outputs 800610655
// Release: Outputs 22879
class C1
{
    public sbyte F1;
    public uint F2;
    public C1(uint f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static uint[] s_1 = new uint[]{0};
    public static void Main()
    {
        C1 vr7 = new C1(800610655U);
        char vr8 = (char)vr7.F2;
        var vr9 = vr7.F1;
        vr8 = vr8;
        s_1[0] = vr7.F2;
        System.Console.WriteLine(s_1[0]);
    }
}