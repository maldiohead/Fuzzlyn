// Generated by Fuzzlyn on 2018-07-04 06:12:36
// Seed: 5721772932072987305
// Reduced from 52.5 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_20 = new char[, ]{{'q'}};
    public static void Main()
    {
        ulong vr0 = (uint)(0 & s_20[0, 0]) % s_20[0, 0];
    }
}