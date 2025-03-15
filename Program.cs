using System;

namespace EX_4
{
    class Program
    {
        static int getNumberOfCombinations(int amount)
        {
            int[] coins = { 1, 5, 10, 20, 25, 50 }; //Available coins
            int[] dp = new int[amount + 1]; //Create and initialize vector
            dp[0] = 1; // Base case: one way to make amount 0 --> Initialization

            foreach (int coin in coins)
            {
                for (int j = coin; j <= amount; j++) //Combine coins less than the total value with coins less than the current coin value.
                {
                    dp[j] += dp[j - coin];
                }
            }

            return dp[amount];
        }

        static void Main()
        {
            Console.WriteLine(getNumberOfCombinations(10)); // Output: 4
            Console.WriteLine(getNumberOfCombinations(20)); // Output: 10
            Console.WriteLine(getNumberOfCombinations(50)); // Output: 72
        }
    }
}
