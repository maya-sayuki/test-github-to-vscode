using  System;

namespace test_github_to_vscode
{
    public class MyRect
    {
        int Width, Height;

        public MyRect(int w, int h)
        {
            Width =  w;
            Height = h;
        }

        public int Area()
        {
            return Width*Height;
        }
    }

    static void Main()
    {
        MyRect rect = new MyRect(50,30);
        int r = rect.Area();
        Console.WriteLine(r);
    }
}