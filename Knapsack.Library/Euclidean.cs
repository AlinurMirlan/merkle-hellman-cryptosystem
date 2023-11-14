using System.Numerics;

namespace Knapsack.Library;

public static class Euclidean
{
    public static BigInteger CommonDivisor(BigInteger a, BigInteger b)
    {
        if (a == 0)
            return b;

        return CommonDivisor(b % a, a);
    }

    /// <summary>
    /// Extended Euclidean Algorithm finds integer coefficients x and y such that: ax + by = gcd(a, b) 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static BigInteger CommonDivisorExtended(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y)
    {
        // Base Case
        if (a == 0)
        {
            x = 0;
            y = 1;
            return b;
        }

        // To store results of
        // recursive call
        BigInteger x1 = 1, y1 = 1;
        BigInteger gcd = CommonDivisorExtended(b % a, a, ref x1, ref y1);

        // Update x and y using
        // results of recursive call
        x = y1 - (b / a) * x1;
        y = x1;

        return gcd;
    }
}
