using System;

class ASCII
{
    static void Main()
    {
        char ch;

        do
        {
            ch = (char) Console.Read();
            if (ch >= 'a' & ch <= 'z')
            {
                ch -= (char) 32;
                Console.WriteLine(ch);
            }
            else if(ch >= 'A' & ch <= 'Z')
            {

                ch += (char) 32;
                Console.WriteLine(ch);
            } 
            
        } while (ch != '.');
    }
}