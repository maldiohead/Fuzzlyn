// Generated by Fuzzlyn on 2018-06-24 05:13:42
// Seed: 11026678175869077986
// Reduced from 14.3 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        var vr8 = new ulong[][, ]{new ulong[, ]{{0}}};
        byte vr13 = (byte)(vr8[0][0, 0] & 0);
        vr8[0][0, 0]++;
        M6(vr13);
    }

    static ulong M6(byte arg0)
    {
        byte var1 = default(byte);
        System.Console.WriteLine(var1);
        return 0;
    }
}