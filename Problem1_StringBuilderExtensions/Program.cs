using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello Good Bye");
        Console.WriteLine(sb);
        Console.WriteLine(sb.Substring(6, 4));
        sb.RemoveText("good");
        Console.WriteLine(sb);
        char[] letters = new char[] { ' ', '!', '?' };
        sb.AppendAll(letters);
        Console.WriteLine(sb);
        List<string> words = new List<string>() { " here", " we", " go" };
        sb.AppendAll(words);
        Console.WriteLine(sb);
    }
}