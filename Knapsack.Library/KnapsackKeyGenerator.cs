using System.Numerics;

namespace Knapsack.Library;

public class KnapsackKeyGenerator
{
    private readonly Random _random = new();

    public KnapsackKeyGenerator(SuperSequenceGenerator sequenceGenerator, int margin = 9999)
    {
        SuperSequenceGenerator = sequenceGenerator;
        Margin = margin;
    }

    public SuperSequenceGenerator SuperSequenceGenerator { get; set; }
    public int Margin { get; set; }

    public KnapsackKeyPair GetKnapsackKeyPair()
    {
        var superSequence = SuperSequenceGenerator.GenerateSequence();
        BigInteger minimum = 1;
        foreach (var number in superSequence)
            minimum += number;

        var modulo = _random.NextBigInteger(minimum, minimum + Margin);
        modulo = modulo % 2 == 0 ? modulo + 1 : modulo;
        var factor = Coprime(modulo);
        var publicKeySequence = new BigInteger[superSequence.Length];
        for (int i = 0; i < publicKeySequence.Length; i++)
            publicKeySequence[i] = factor * superSequence[i] % modulo;

        var privateKey = new KnapsackPrivateKey(superSequence, modulo, factor);
        return new(publicKeySequence, privateKey);
    }

    private BigInteger Coprime(BigInteger number)
    {
        if (number <= 0)
            throw new ArgumentException("Number has to be positive");

        BigInteger coprime;
        do
        {
            coprime = _random.NextBigInteger(1, number);
        }
        while (Euclidean.CommonDivisor(coprime, number) != 1);

        return coprime;
    }
}