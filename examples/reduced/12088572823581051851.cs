// Generated by Fuzzlyn on 2018-07-21 00:15:29
// Seed: 12088572823581051851
// Reduced from 21.1 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static uint[][, ] s_1 = new uint[][, ]{new uint[, ]{{0}}};
    public static void Main()
    {
        var vr12 = (sbyte)(0 & s_1[0][0, 0]);
        var vr13 = s_1[0][0, 0];
        M5(vr12);
    }

    static byte M5(sbyte arg0)
    {
        System.Console.WriteLine(-6737414862809808077L);
        return 0;
    }
}
