// Generated by Fuzzlyn on 2018-06-25 17:07:10
// Seed: 7745658615694934701
// Reduced from 89.1 KiB to 0.8 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
struct S0
{
    public short F4;
    public sbyte F5;
    public char F6;
    public bool F7;
    public S0(bool f7): this()
    {
        F7 = f7;
    }
}

struct S1
{
    public S0 F2;
    public S0 F7;
    public S1(S0 f2): this()
    {
        F2 = f2;
    }
}

struct S2
{
    public S1 F0;
    public S2(S1 f0): this()
    {
        F0 = f0;
    }
}

struct S4
{
    public byte F0;
}

public class Program
{
    public static void Main()
    {
        M4();
    }

    static char M4()
    {
        S2 var11 = new S2(new S1(new S0(true)));
        bool vr9 = var11.F0.F2.F7;
        if (vr9)
        {
            return var11.F0.F7.F6;
        }
        else
        {
        }

        S4 vr19 = default(S4);
        System.Console.WriteLine(vr19.F0);
        return 'i';
    }
}