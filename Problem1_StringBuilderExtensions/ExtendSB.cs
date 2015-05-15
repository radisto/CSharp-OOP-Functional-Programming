using System;
using System.Collections.Generic;
using System.Text;

static class ExtendSB
{
    public static string Substring(this StringBuilder sb, int startIndex, int length)
    {
        if (length == 0)
        {
            return "";
        }
        string sbToString = sb.ToString();
        if (startIndex >= sbToString.Length)
        {
            throw new IndexOutOfRangeException("The start index is bigger than the String Builder itself.");
        }
        if (length > sbToString.Length - startIndex)
        {
            length = sbToString.Length - startIndex;
            // This way if the length is too big, it bacomes the maximum possible length which makes the method more frexible in my opinion.
        }
        string newStr = "";
        for (int i = startIndex, j = 0; i < sbToString.Length; i++, j++)
        {
            if (j == length)
            {
                break;
            }
            newStr += sbToString[i];
        }
        return newStr;
    }

    public static StringBuilder RemoveText(this StringBuilder sb, string text)
    {
        text = text.ToLower();
        string sbPart = "";
        string newStr = sb.ToString();
        sb.Clear();
        int n = text.Length;
        for (int i = 0; i < newStr.Length-n+1; i++)
        {
            sbPart = "";
            for (int j = 0; j < n; j++)
            {
                sbPart += newStr[i+j];
            }
            sbPart = sbPart.ToLower();
            if (text == sbPart)
            {
                newStr = newStr.Substring(0, i) + newStr.Substring(i + n, newStr.Length-i-n);
                i--;
            }
        }
        return sb.Append(newStr);
    }

    public static StringBuilder AppendAll<T>(this StringBuilder sb, IEnumerable<T> items)
    {
        foreach (var i in items)
        {
            sb.Append(i.ToString());
        }
        return sb;
    }
}