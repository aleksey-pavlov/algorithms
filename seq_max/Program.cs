using System;

namespace seq_max
{
    class Program
    {
        static void Main(string[] args)
        {
            var seq = new int[]{ 1,1,1,1,0,1,1,1,1,1,1,0,1 };

            var len = sequenceLen(seq);

            Console.WriteLine(len);
        }

        static int sequenceLen(int[] seq)
        {
            var max = 0;
            var current = 0;

            if (seq.Length == 0) {
                return 0;
            }

            foreach (var i in seq) {

                if (i > 0) {
                    current++;
                    max = Math.Max(current, max);
                } else
                    current = 0;
            }

            return max;
        }
    }
}
