// Generated by Fuzzlyn on 2018-07-11 10:31:16
// Seed: 4723721714255433435
// Reduced from 60.3 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint[, ] s_2 = new uint[, ]{{0}};
    public static void Main()
    {
        var vr45 = s_2[0, 0];
        System.Console.WriteLine(0);
        var vr49 = (0 & s_2[0, 0]) - M14(0, M14(s_2[0, 0], 0));
        M14(vr45, vr49);
    }

    static byte M14(uint arg0, long arg1)
    {
        System.Console.WriteLine(arg0);
        return 0;
    }
}