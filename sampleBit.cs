using System;

class UpCase
{
    static void Main()
    {
        char ch;

        for (int i = 0; i < 10; i++)
        {
            ch = (char) ('a' + i);
            Console.Write(ch);

            ch = (char) (ch & 65303);

            Console.Write(ch + " ");
        }

        int t;

        byte val;

        val = 123;
        for(t = 128; t >0; t = t/2)
        {
            if ((val & t) != 0)
            {
                Console.Write("1");
            }else
            {
                Console.Write("0 ");
            }
        }
    }
}