namespace Algorithms
{
    public static class GreatestCommonDivisor
    {
        /// <summary>
        /// Calculate GCD using for-loop (Non Recursive).
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int Get(int a, int b)
        {
            var best = 0;
            for (int d = 1; d < a + b; d++) if (a % d == 0 && b % d == 0) best = d;
            return best;
        }

        /// <summary>
        /// Calculate GCD using Euclidean algorithm (Recursively).
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetUsingEuclideanAlgorithm(int a, int b) => b is 0 ? a : GetUsingEuclideanAlgorithm(b, a % b);
    }
}
