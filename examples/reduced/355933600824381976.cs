// Generated by Fuzzlyn v1.1 on 2018-08-22 06:23:27
// Seed: 355933600824381976
// Reduced from 2.2 KiB to 0.4 KiB
// Debug: Outputs 65281
// Release: Outputs 257
public class Program
{
    static byte s_2;
    static ushort s_3;
    public static void Main()
    {
        byte[] vr4 = new byte[]{255};
        byte vr5 = vr4[0]++;
        var vr6 = (byte)(vr4[0] | 1);
        var vr7 = (ushort)(0 - vr5);
        M1(ref s_3, vr6, vr7);
    }

    static ref byte M1(ref ushort arg0, byte arg1, ushort arg2)
    {
        System.Console.WriteLine(arg2);
        return ref s_2;
    }
}