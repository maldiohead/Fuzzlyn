// Generated by Fuzzlyn on 2018-07-14 13:19:53
// Seed: 18415481970287163949
// Reduced from 3.1 KiB to 0.2 KiB
// Debug: Outputs 255
// Release: Outputs 65535
public class Program
{
    static char s_2;
    public static void Main()
    {
        byte[] vr2 = new byte[]{0};
        vr2[0] = 0;
        --vr2[0];
        s_2 = (char)vr2[0];
        System.Console.WriteLine((int)s_2);
    }
}
