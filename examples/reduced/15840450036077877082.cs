// Generated by Fuzzlyn on 2018-07-02 08:00:29
// Seed: 15840450036077877082
// Reduced from 44.2 KiB to 0.2 KiB
// Debug: Outputs 63154
// Release: Outputs 4294964914
public class Program
{
    static short[] s_2 = new short[]{-2382};
    public static void Main()
    {
        long vr17 = default(long);
        vr17 = (ushort)(s_2[0] | vr17);
        System.Console.WriteLine(vr17);
    }
}