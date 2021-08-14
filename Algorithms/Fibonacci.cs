namespace Algorithms
{
    public static class Fibonacci
    {
        public static int GetNthRecursively(int n) => n is 0 ? 0 : n is 1 ? 1 : GetNthRecursively(n - 1) + GetNthRecursively(n - 2);
        public static int GetNthNonRecursively(int n)
        {
            if (n is 0) return 0;
            if (n is 1) return 1;
            int[] fibonacci = new int[n + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci[n];
        }
    }
}
