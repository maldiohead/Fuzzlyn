// Generated by Fuzzlyn on 2018-07-05 06:34:24
// Seed: 15341209915803714729
// Reduced from 88.7 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[, ] s_12 = new int[, ]{{0}};
    public static void Main()
    {
        var vr19 = 0 & s_12[0, 0];
        var vr20 = s_12[0, 0];
        uint[, ] vr21 = new uint[, ]{{0}};
        M42('.', vr19, vr21);
    }

    static uint M42(char arg0, long arg2, uint[, ] arg7)
    {
        System.Console.WriteLine((int)arg0);
        return arg7[0, 0];
    }
}