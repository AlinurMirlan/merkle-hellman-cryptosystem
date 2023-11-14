using System.Numerics;

namespace Knapsack.Library;

public class SuperSequenceGenerator
{
    private readonly Random _random = new();

    public SuperSequenceGenerator(int size, int margin = 100)
    {
        Size = size;
        Margin = margin;
    }

    public int Size { get; set; }
    public int Margin { get; set; }

    public BigInteger[] GenerateSequence()
    {
        var sequence = new BigInteger[Size];
        for (int i = 0; i < Size; i++)
        {
            BigInteger sumOfElements = 0;
            for (int j = 0; j < i; j++)
                sumOfElements += sequence[j];
            BigInteger minimum = sumOfElements + 1;
            sequence[i] = _random.NextBigInteger(minimum, minimum + Margin);
        }

        return sequence;
    }
}
