// Generated by Fuzzlyn v1.1 on 2018-08-10 13:28:51
// Seed: 14575034649663590227
// Reduced from 23.2 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static sbyte[] s_6;
    public static void Main()
    {
        s_6 = new sbyte[]{-2};
        ushort vr4 = (ushort)((uint)0 ^ s_6[0]);
        ulong vr3 = vr4;
        System.Console.WriteLine(vr3);
    }
}