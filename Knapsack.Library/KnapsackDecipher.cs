using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;

namespace Knapsack.Library;

public class KnapsackDecipher
{
    private BigInteger _factor;
    private BigInteger _modulo;
    private int _blockSize;
    private BigInteger[] _superSequence = Array.Empty<BigInteger>();
    private KnapsackPrivateKey _privateKey;
    private const int CharBitCount = 16;

    public KnapsackDecipher(KnapsackPrivateKey privateKey)
    {
        PrivateKey = privateKey;
        _privateKey = privateKey;
    }

    public KnapsackPrivateKey PrivateKey
    {
        get => _privateKey;
        set
        {
            _privateKey = value;
            _factor = _privateKey.Factor;
            _modulo = _privateKey.Modulo;
            _superSequence = _privateKey.SuperSequence;
            _blockSize = _superSequence.Length;
        }
    }

    public string Decrypt(string message)
    {
        var bits = DecryptRaw(message);
        StringBuilder decryptedBuilder = new();
        int leftover = bits.Length % CharBitCount;
        if (leftover != 0)
            bits = bits[0..(bits.Length - leftover)];

        for (int i = 0; i < bits.Length; i += CharBitCount)
        {
            int intChar = Convert.ToInt32(bits[i..(i + CharBitCount)], 2);
            decryptedBuilder.Append(Convert.ToChar(intChar));
        }

        return decryptedBuilder.ToString();
    }

    public string DecryptRaw(string message)
    {
        BigInteger factorInverse = 0, moduloInverse = 0;
        Euclidean.CommonDivisorExtended(_factor, _modulo,
            ref factorInverse, ref moduloInverse);
        if (factorInverse < 0)
            factorInverse += _modulo;

        StringBuilder decipherBuilder = new();
        foreach (var cipherNumber in message.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            var number = BigInteger.Parse(cipherNumber);
            var decipherNumber = number * factorInverse % _modulo;
            string decipheredBits = GetDecipheredBits(decipherNumber);
            decipherBuilder.Append(decipheredBits);
        }

        return decipherBuilder.ToString();
    }

    private string GetDecipheredBits(BigInteger cipherNumber)
    {
        StringBuilder bitsBuilder = new();
        for (int i = 1; i <= _blockSize; i++)
        {
            var sequenceNumber = _superSequence[^i];
            if (cipherNumber / sequenceNumber > 0)
            {
                bitsBuilder.Insert(0, '1');
                cipherNumber -= sequenceNumber;
            }
            else
                bitsBuilder.Insert(0, '0');
        }

        return bitsBuilder.ToString();
    }
}
