// Generated by Fuzzlyn on 2018-06-20 02:09:21
// Seed: 10660129064315118559
// Reduced from 124.6 KiB to 0.2 KiB
// Debug: Outputs 65331
// Release: Outputs -205
public class Program
{
    static short s_1 = -206;
    public static void Main()
    {
        char vr13 = (char)(s_1 ^ 1L);
        System.Console.WriteLine((int)vr13);
    }
}