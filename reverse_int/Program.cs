int x = -2147483412;
Console.WriteLine(Reverse(x));

int Reverse(int x)
{
    Span<char> xrev = stackalloc char[11];
    x.TryFormat(xrev, out int written);
    if (x < 0)
    {
        xrev = xrev.Slice(1, written - 1);
    }
    else
    {
        xrev = xrev.Slice(0, written);
    }

    xrev.Reverse();

    return int.TryParse(xrev, out int r) ? (x < 0 ? -r : r) : 0;
}