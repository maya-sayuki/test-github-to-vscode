using System;

class OverloadDemo
{
    static void Main()
    {
        Overload ob = new Overload();
        int  resI;
        double resD;

        ob.OvlDemo();
        Console.WriteLine();

        ob.OvlDemo(2);
        Console.WriteLine();

        restI = ob.OvlDemo(4, 6);
        Console.WriteLine("Result of ob.OvlDemo(4,6)" + resI);
        Console.WriteLine();

        resD = ob.OvlDemo(1.1, 2.32);
        Console.WriteLine(resD);

    }
}