using System;

class sample35
{
    public int TricIncrement(int num)
    {
        for (int i = 1; i <= num; i +=i; )// 模範解答なのになぜか問題
        {
            Console.WriteLine(i);
        }
    }
}