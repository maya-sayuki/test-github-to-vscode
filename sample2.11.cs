using System;

class Eratos
{
    static List<int> SieveOfEratos(int n)
    {
        var p = new List<int>();
        var s = new List<int>();
        if(n < 2) return p;

        for (int i = 2; i < n; i++)
        {
            s.Add(i);
        }

        while (s[0] * s[0] <= n)
        {
            var prime = s[0];
            p.Add(prime);
            s.ReemoveAt(0);

            s.ReemoveAll(x => x % prime == 0);
        }

        p.AddRange(s);
        return p;
    }
}