// Generated by Fuzzlyn on 2018-06-28 20:55:21
// Seed: 735866401455697746
// Reduced from 6.5 KiB to 0.2 KiB
// Debug: Outputs 32779
// Release: Outputs 4294934539
public class Program
{
    public static void Main()
    {
        var vr17 = new short[][]{new short[]{-32767}};
        char vr19 = (char)(vr17[0][0] ^ 10L);
        uint vr20 = vr19;
        System.Console.WriteLine(vr20);
    }
}