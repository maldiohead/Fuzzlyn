// Generated by Fuzzlyn v1.1 on 2018-08-25 04:32:04
// Seed: 12338767090983457166
// Reduced from 1.7 KiB to 0.2 KiB
// Debug: Outputs 2257334173
// Release: Outputs 157
public class Program
{
    static uint[] s_1;
    public static void Main()
    {
        s_1 = new uint[]{2257334174U};
        var vr2 = (byte)s_1[0] / s_1[0]--;
        System.Console.WriteLine(s_1[0]);
    }
}