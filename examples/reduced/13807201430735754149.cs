// Generated by Fuzzlyn on 2018-06-29 07:56:27
// Seed: 13807201430735754149
// Reduced from 39.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[][, ] s_3 = new ushort[][, ]{new ushort[, ]{{0}}};
    public static void Main()
    {
        sbyte vr0 = (sbyte)(0 % (((0 & s_3[0][0, 0]) | s_3[0][0, 0]) | 1));
    }
}