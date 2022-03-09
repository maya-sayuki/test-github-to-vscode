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