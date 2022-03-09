using System;

/*SimpleQはサイズが固定で、１回のみ使用し、使用済み空き領域
を再利用しない*/
class SimpleQ
{
    //配列は不変長
    char[] q;
    //put操作、get操作用の添え字
    //putloc:現在格納されている最後の要素を指す添え字
    //getloc:常に、取り出された最後の要素の位置を指す添え字
    int putloc, getloc;
    //コンストラクター
    public SimpleQ(int size)
    {
        //キュー用にメモリを確保する
        q = new char[size+1];

        putloc =getloc = 0;
    }
    //put操作：一文字分だけキューに追加する
    public void Put(char ch)
    {
        //キューがいっぱいかどうかの確認
        if (putloc==q.Length-1)
        {
            Console.WriteLine("Q is full.");
            return;
        }

        putloc++;
        //putlocの位置に新しく文字が格納される
        q[putloc] = ch;
    }
    //get操作：キューから一文字だけ取り出す
    public char Get()
    {
        //キューが空かどうか確認する
        if (getloc==putloc)
        {
            Console.WriteLine("Q is empty.");
            return (char) 0;
        }

        getloc++;
        return q[getloc];
    }
}
class Stack
{
    //スタックのデータ本体配列stckを作成
    char[]  stck;
    //スタックトップを表す添え字
    int tos;

    //コンストラクターでサイズを指定した
    //空のスタックを作る
    public Stack(int size)
    {
        stck = new char[size];
        tos = 0;
    }
    //与えられたスタックから新しいスタックを作る
    public Stack(Stack ob)
    {
        tos =ob.tos;
        stck = new char[ob.stck.Length];
        //要素のコピー
        for (int i = 0; i < tos; i++)
        {
            stck[i] = ob.stck[i];
        }
    }
    //char型配列を初期値としてスタックを作る
    public Stack(char[] a)
    {
        stck = new char[a.Length];
        
        for (int i = 0; i < a.Length; i++)
        {
            Push(a[i]);
        }
    }

    public Push(char ch)
    {
        if (tos==stck.Length)
        {
            Console.WriteLine("Stack is full.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    public char Pop()
    {
        if (tos==0)
        {
            Console.WriteLine("Stack is empty");
            return (char) 0;
        }

        tos--;
        return stck[tos];
    }
}