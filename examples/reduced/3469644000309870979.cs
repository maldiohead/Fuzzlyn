// Generated by Fuzzlyn on 2018-06-23 08:37:50
// Seed: 3469644000309870979
// Reduced from 53.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_9 = new ushort[, ]{{0}};
    public static void Main()
    {
        char vr0 = (char)((0 % ((0 & s_9[0, 0]) | 1)) | s_9[0, 0]);
    }
}