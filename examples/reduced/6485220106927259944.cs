// Generated by Fuzzlyn on 2018-07-02 17:07:36
// Seed: 6485220106927259944
// Reduced from 47.0 KiB to 0.2 KiB
// Debug: Outputs 36865
// Release: Outputs 4294938625
public class Program
{
    static short[] s_1 = new short[]{29376};
    public static void Main()
    {
        s_1[0] *= s_1[0];
        var vr25 = (char)(s_1[0] | 1L);
        ulong vr26 = vr25;
        System.Console.WriteLine(vr26);
    }
}