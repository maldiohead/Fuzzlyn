// Generated by Fuzzlyn v1.1 on 2018-08-28 05:11:14
// Seed: 9715237822735266140
// Reduced from 42.2 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs 254
public class Program
{
    static ushort[] s_17 = new ushort[]{0};
    public static void Main()
    {
        byte[] vr14 = new byte[]{254};
        byte vr15 = vr14[0];
        s_17[0] = 65535;
        var vr16 = s_17[0]--;
        System.Console.WriteLine(s_17[0]);
    }
}