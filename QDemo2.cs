using System;

class SimpleQueue
{
    char[] q;
    int putloc, getloc;


    public SimpleQueue(int size)
    {
        q = new char[size+1];
        putloc = getloc = 0;
    }

    public SimpleQueue(SimpleQueue ob)
    {
        putloc = ob.putloc;
        getloc = ob.getloc;
        q = new char [ob.q.Length];

        for (int i = getloc+1; i <= putloc; i++)
        {
            q[i] = ob.q[i];
        }

    }

    public SimpleQueue(char[] a)
    {
        putloc = 0;
        getloc = 0;
        q = new char[a.Length+1];
        for (int i = 0; i < a.Length; i++)
        {
            Put(a[i]);            
        }
    }

    public void Put(char ch)
    {
        if (putloc == q.Length-1)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        putloc++;
        q[putloc] = ch;
    }

    public char Get()
    {
        if (getloc==putloc)
        {
            Console.WriteLine("Queue is empty");
            return (char) 0;
        }

        getloc++;
        return q[getloc];
    }
}