// Generated by Fuzzlyn v1.1 on 2018-08-13 12:53:03
// Seed: 10811173942112130540
// Reduced from 55.0 KiB to 0.7 KiB
// Debug: Outputs 32767
// Release: Outputs -8355585
public class Program
{
    public static void Main()
    {
        var vr38 = new uint[]{0};
        M2(vr38, 0);
    }

    static void M2(uint[] arg0, sbyte arg1)
    {
        arg1 = (sbyte)(arg0[0] ^ 254);
        try
        {
            arg0[0] = 0;
        }
        finally
        {
            var vr18 = arg0[0];
            var vr14 = M3(vr18, arg1);
        }

        var vr27 = arg1++;
        var vr37 = -32767 * arg1;
        var vr35 = M4(vr37);
    }

    static uint M3(uint arg0, sbyte arg2)
    {
        System.Console.WriteLine(arg0);
        return arg0;
    }

    static uint M4(long arg0)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}
