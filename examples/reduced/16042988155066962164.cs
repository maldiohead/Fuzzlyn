// Generated by Fuzzlyn on 2018-07-19 23:44:32
// Seed: 16042988155066962164
// Reduced from 8.2 KiB to 0.3 KiB
// Debug: Outputs 2147483647
// Release: Outputs -1
class C1
{
    public uint F0;
    public int F5;
    public C1(int f5)
    {
        F5 = f5;
    }
}

public class Program
{
    public static void Main()
    {
        C1 vr5 = new C1(2147483647);
        vr5.F0 = (uint)(sbyte)vr5.F5;
        vr5.F5 = vr5.F5;
        System.Console.WriteLine(vr5.F5);
    }
}