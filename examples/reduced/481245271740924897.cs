// Generated by Fuzzlyn on 2018-06-22 21:25:18
// Seed: 481245271740924897
// Reduced from 3.0 KiB to 0.4 KiB
// Debug: Outputs 215
// Release: Outputs 40407
struct S1
{
    public char F1;
    public S1(char f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        byte[] vr1 = new byte[]{0};
        vr1[0] = 255;
        S1 vr2 = new S1((char)(vr1[0] & (2930089256U ^ vr1[0])));
        char vr3 = vr2.F1;
        System.Console.WriteLine((int)vr3);
    }
}
