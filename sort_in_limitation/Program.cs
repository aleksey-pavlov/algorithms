
using System.Text;

namespace sort_in_limitation
{
    class Program
    {

        private static string sourceFileName = "source.tmp";
        private static string resultFileName = "result.tmp";

        public static async Task Main(string[] args)
        {
            await CreateTestData();

            var stat = new Dictionary<char, int>();

            using (var file = new FileStream($"./{sourceFileName}", FileMode.Open))
            {
                var count = 10;

                while (file.Position < file.Length)
                {
                    byte[] output = new byte[count];

                    await file.ReadAsync(output, 0, count);

                    count = Math.Min(count, (int)file.Length - (int)file.Position);

                    var sequence = Encoding.Default.GetString(output);

                    foreach (var i in sequence)
                    {
                        if (!stat.TryGetValue(i, out int _))
                        {
                            stat[i] = 0;
                        }

                        stat[i]++;
                    }
                }
            }

            using (var file = new FileStream(resultFileName, FileMode.Create))
            {
                foreach (var i in stat)
                {
                    for (var j = i.Value; j > 0; j--)
                    {
                        await file.WriteAsync(Encoding.Default.GetBytes($"{i.Key}"));
                    }

                    Console.WriteLine($"{i.Key}:{i.Value}");
                }

            }

        }

        public static async Task CreateTestData()
        {
            using (var file = new FileStream($"./{sourceFileName}", FileMode.Create))
            {
                for (var i = 0; i < 10000000; i++)
                {
                    await file.WriteAsync(Encoding.Default.GetBytes($"{i + 1}"));
                }
            }
        }
    }
}

