// Find max lenght uniq substring
// Input: "abcdeabcaaabbbccc"
// Out: 5 "abcde"

string str = "abcdeabcaaabbbccc";

Dictionary<char, int> charStat = new Dictionary<char, int>();

int left = 0;
int maxLen = 0;

for (var right = 0; right < str.Length; ) {

    var charRight = str[right];
    var charLeft = str[left];
    
    if ( !charStat.TryGetValue(charRight, out int _) ) {
        charStat[charRight] = 1;
        right++;
    } else {
        charStat.Remove(charLeft);
        left++;  
    }

    maxLen = Math.Max(maxLen, right - left);

}

Console.WriteLine(maxLen);