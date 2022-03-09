using System;
class Encode
{
    static void Main()
    {
        string msg = "this is a test";
        string encmsg = "";
        string decmsg = "";
        int key = 88;

        Console.WriteLine(msg);

        //エンコード
        for (int i = 0; i < msg.Length; i++)
        {
            encmsg = encmsg + (char) (msg[i] ^ key);
        }

        Console.WriteLine(encmsg);

        //デコード
        for (int i = 0; i < msg.Length; i++)
        {
            decmsg = decmsg + (char) (encmsg[i] ^ key);
            Console.WriteLine(decmsg);
        }
    }
}