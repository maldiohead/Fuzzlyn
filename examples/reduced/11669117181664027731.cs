// Generated by Fuzzlyn on 2018-06-28 05:09:47
// Seed: 11669117181664027731
// Reduced from 30.5 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.IndexOutOfRangeException'
public class Program
{
    public static void Main()
    {
        var vr1 = new short[][, ]{new short[, ]{{0}}};
        M2(vr1);
    }

    static byte M2(short[][, ] arg1)
    {
        sbyte var1 = (sbyte)(0 & arg1[0][0, 0]);
        System.Console.WriteLine(arg1[0][0, 0]);
        System.Console.WriteLine(var1);
        return 0;
    }
}