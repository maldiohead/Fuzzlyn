// Generated by Fuzzlyn on 2018-07-09 23:32:39
// Seed: 1403897006621022180
// Reduced from 25.3 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr7 = new long[][][, ]{new long[][, ]{new long[, ]{{0}}}};
        M3(vr7);
    }

    static int M3(long[][][, ] arg2)
    {
        uint var2 = (uint)(arg2[0][0][0, 0] & 0);
        System.Console.WriteLine(var2);
        System.Console.WriteLine(arg2[0][0][0, 0]);
        return 0;
    }
}