using System;

class Bubble
{

    static void Main()
    {
        int n,a,b;
        string t;
        string[] str = new string[n];

        for (a = 1; a < size; a++)
        {
            for (b = size-1; b >= a; b--)
            {
                if (str[b-1] > str[b])
                {
                    t =str[b-1];
                    str[b-1] = str[b];
                    str[b] = t;
                }
            }
            
        }
    }
}