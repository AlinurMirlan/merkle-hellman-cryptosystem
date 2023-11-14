using System.Numerics;
using System.Text;

namespace Knapsack.Library;

public class KnapsackCipher
{
    private int _blockSize;
    private BigInteger[] _publicKey;
    private const int CharBitCount = 16;

    public KnapsackCipher(params BigInteger[] publicKey)
    {
        _publicKey = publicKey;
        _blockSize = _publicKey.Length;
    }

    public BigInteger[] PublicKey
    {
        get => _publicKey;
        set
        {
            _publicKey = value;
            _blockSize = _publicKey.Length;
        }
    }

    public string Encrypt(string message)
    {
        string messageBits = GetBits(message);
        int leftover = messageBits.Length % _blockSize;
        if (leftover != 0)
            messageBits = messageBits.PadRight(messageBits.Length + _blockSize - leftover, '0');

        StringBuilder cipherNumbersBuilder = new();
        for (int i = 0; i < messageBits.Length; i += _blockSize)
        {
            var cipherNumber = CipherBlock(messageBits[i..(i + _blockSize)]);
            cipherNumbersBuilder.Append($"{cipherNumber} ");
        }

        return cipherNumbersBuilder.ToString();
    }

    private BigInteger CipherBlock(string block)
    {
        BigInteger cipherNumber = 0;
        for (int i = 0; i < _blockSize; i++)
        {
            if (block[i] == '0')
                continue;

            cipherNumber += PublicKey[i];
        }

        return cipherNumber;
    }

    private static string GetBits(string message)
    {
        StringBuilder builder = new();
        foreach (var character in message)
        {
            string bits = Convert.ToString(character, 2).PadLeft(CharBitCount, '0');
            builder.Append(bits);
        }

        return builder.ToString();
    }
}
