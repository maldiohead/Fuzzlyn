// Generated by Fuzzlyn on 2018-07-18 19:49:08
// Seed: 4794812215929819544
// Reduced from 14.3 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        int[][, ] vr22 = new int[][, ]{new int[, ]{{0}}};
        var vr23 = (0 & vr22[0][0, 0]) % 'v';
        var vr24 = vr22[0][0, 0];
    }
}
