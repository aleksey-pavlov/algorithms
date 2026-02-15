// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var ss = "babad";

var p = new Palindrome();
Console.WriteLine(p.FindPalindrome(ss));

class Palindrome
{
    public string FindPalindrome(string s)
    {
        var left = 0;
        var right = 0;
        
        for (var i = 0; i < s.Length; i++)
        {
            int exp1 = Expand(i, i, s);
            if (right - left + 1 < exp1)
            {
                int d = exp1 / 2;
                left = i - d;
                right = i + d;
            }
            
            int exp2 = Expand(i, i + 1, s);
            if (right - left + 1 < exp2)
            {
                int d = (exp2 / 2) - 1;
                left = i - d;
                right = i + d + 1;
            }
        }

        return s.Substring(left, right - left + 1);
    }

    int Expand(int i, int j, string s)
    {
        var left = i;
        var right = j;
        
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        
        return right - left - 1;
    }
}