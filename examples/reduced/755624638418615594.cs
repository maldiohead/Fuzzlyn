// Generated by Fuzzlyn on 2018-07-13 02:06:14
// Seed: 755624638418615594
// Reduced from 96.4 KiB to 0.2 KiB
// Debug: Outputs 65409
// Release: Outputs -127
public class Program
{
    public static void Main()
    {
        sbyte[] vr14 = new sbyte[]{-128};
        int vr15 = (char)(1U | vr14[0]);
        System.Console.WriteLine(vr15);
    }
}