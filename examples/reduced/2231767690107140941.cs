// Generated by Fuzzlyn v1.1 on 2018-08-20 20:40:44
// Seed: 2231767690107140941
// Reduced from 103.5 KiB to 0.5 KiB in 00:02:27
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F3;
    public sbyte F5;
    public S0(sbyte f5): this()
    {
        F5 = f5;
    }
}

public class Program
{
    static S0[] s_22 = new S0[]{new S0(1)};
    public static void Main()
    {
        M23() = s_22[0];
        byte[] vr4 = new byte[]{0};
        vr4[0] = (byte)s_22[0].F5;
        System.Console.WriteLine(vr4[0]);
    }

    static ref S0 M23()
    {
        s_22 = new S0[]{new S0(0)};
        return ref s_22[0];
    }
}
