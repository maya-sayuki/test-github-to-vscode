using System;

class Overload
{
    public void OvlDemo()
    {
        Console.WriteLine("NO parameters");
    }

    public void OvlDemo(int a)
    {
        Console.WriteLine("One parameter" + a);
    }

    public int OvlDemo(int a, int b)
    {
        Console.WriteLine("Two parameters" + a +"" + b);
    }

    public double OvlDemo(double a, double b)
    {
        Console.WriteLine("Two double parametres" + a + " " + b);

        return a + b;
    }
}