// Generated by Fuzzlyn on 2018-07-08 15:19:03
// Seed: 3611136677048312456
// Reduced from 212.2 KiB to 0.2 KiB
// Debug: Outputs 34000
// Release: Outputs 4294935760
public class Program
{
    static short s_10 = -31536;
    public static void Main()
    {
        char vr29 = (char)(0U ^ s_10);
        ulong vr32 = vr29;
        System.Console.WriteLine(vr32);
    }
}