// Generated by Fuzzlyn on 2018-06-30 21:47:08
// Seed: 17987951381015275746
// Reduced from 279.8 KiB to 0.4 KiB
// Debug: Outputs 65502
// Release: Outputs 4294967262
class C0
{
    public sbyte F6;
    public C0(sbyte f6)
    {
        F6 = f6;
    }
}

public class Program
{
    static C0 s_2 = new C0(-34);
    static short[, ] s_51 = new short[, ]{{0}};
    static uint s_103;
    public static void Main()
    {
        s_103 = (ushort)(s_2.F6 | s_51[0, 0]);
        System.Console.WriteLine(s_103);
    }
}