// Generated by Fuzzlyn v1.1 on 2018-08-22 21:41:11
// Seed: 6475839781211761690
// Reduced from 3.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        byte[][][][, ] vr0 = new byte[][][][, ]{new byte[][][, ]{new byte[][, ]{new byte[, ]{{198}}}}};
        short vr1 = (short)(0 / ((vr0[0][0][0][0, 0] & 0) | vr0[0][0][0][0, 0]));
    }
}