using System;

class Test
{
    int a;
    Test(int i) { a = i;}

    public void Swap(Test ob1, Test ob2)
    {
        Test obA = ob1;
        ob1 = ob2;
        ob2 = obA;
    }
}