// See https://aka.ms/new-console-template for more information

var s = "AB";
int numRows = 1;

var output = "PINALSIGYAHRPI";


string Convert(string s, int numRows)
{
    var mtx = Enumerable.Repeat(string.Empty, numRows).ToList();

    var rowIdx = 0;
    var reverse = false;
    for (int i = 0; i < s.Length; i++)
    {
        mtx[rowIdx] += s[i];

        if (numRows > 1)
        {
            rowIdx = reverse ? rowIdx - 1 : rowIdx + 1;

            if (rowIdx == numRows - 1) reverse = true;
            if (rowIdx == 0) reverse = false;
        }
    }

    return string.Join("", mtx);
}

Console.WriteLine(Convert(s, numRows));