// Generated by Fuzzlyn on 2018-07-08 08:20:21
// Seed: 5698211100185064345
// Reduced from 92.9 KiB to 0.2 KiB
// Debug: Outputs 156
// Release: Outputs -100
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{-100}};
    public static void Main()
    {
        int vr12 = (byte)(s_2[0, 0] / (0U | 1));
        System.Console.WriteLine(vr12);
    }
}