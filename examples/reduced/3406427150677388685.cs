// Generated by Fuzzlyn on 2018-07-08 15:05:08
// Seed: 3406427150677388685
// Reduced from 10.6 KiB to 0.3 KiB
// Debug: Outputs -1913040058
// Release: Outputs 70
class C0
{
    public int F2;
    public byte F3;
    public C0(int f2)
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr2 = new C0(-1913040058);
        vr2.F3 = (byte)vr2.F2;
        var vr3 = vr2.F2;
        System.Console.WriteLine(vr3);
    }
}