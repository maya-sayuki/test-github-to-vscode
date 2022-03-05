using System;

class Summation 
{
    public int Sum;

    public Summation(int num)
    {
        Sum = 0;
        for (int i = 1; i <= num; i++)
        {
            Sum += i;
        }
    }

    public Summation(Summation ob)
    {
        Sum = ob.Sum;
    }
}

class SumDemo
{
    static void Main()
    {
        Summation s1 = new Summation(5);
        Summation s2 = new Summation(s1);
    }
}