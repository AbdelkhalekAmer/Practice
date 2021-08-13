using System;

namespace Algorithms.DynamicProgramming
{
    public static class MaxSumArray
    {
        public static int GetMaxSumByUsingAdditionalArray(int[] array)
        {
            var length = array.Length;
            if (length is 0) return 0;
            if (length is 1) return array[0];
            var dp = new int[length];
            dp[0] = Math.Max(0, array[0]);
            dp[1] = Math.Max(dp[0], array[1]);
            for (int i = 2; i < length; i++) dp[i] = Math.Max(dp[i - 1], array[i] + dp[i - 2]);
            return dp[length - 1];
        }

        public static int GetMaxSumByUsingTheSameInputArray(int[] array)
        {
            var length = array.Length;
            if (length is 0) return 0;
            if (length is 1) return array[0];
            array[0] = Math.Max(0, array[0]);
            array[1] = Math.Max(array[0], array[1]);
            for (int i = 2; i < length; i++) array[i] = Math.Max(array[i - 1], array[i] + array[i - 2]);
            return array[length - 1];
        }
    }
}
