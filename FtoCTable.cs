using System;

class ItoMTable
{
    static void Main()
    {
        double I,m;
        int counter;


        counter = 0;
        for (I = 1d;  I< 144d; I++)
        {
            m = I / 39.37;

            Console.WriteLine(I + "Inti is" + m + " meter");

            counter++;

            if (counter == 12)
            {
                Console.WriteLine();
                counter = 0;
            }
            
        }
    }
}