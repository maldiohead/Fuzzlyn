// Generated by Fuzzlyn on 2018-07-27 14:00:54
// Seed: 7642902021992647163
// Reduced from 162.5 KiB to 0.2 KiB
// Debug: Outputs 65527
// Release: Outputs -9
public class Program
{
    static sbyte[] s_16 = new sbyte[]{-10};
    public static void Main()
    {
        char vr43 = (char)(s_16[0] ^ 1L);
        System.Console.WriteLine((int)vr43);
    }
}
