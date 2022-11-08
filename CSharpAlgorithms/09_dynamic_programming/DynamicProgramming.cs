using System;

namespace ConsoleApplication
{
    public class DynamicProgramming
    {
        public static void LongestCommonSubsequence()
        {
            string wordA = "hish";
            string wordB = "fish";

            int[,] cell = new int[wordA.Count(), wordB.Count()];

            for (int i = 0; i < wordA.Count(); i++)
            {
                for (int j = 0; j < wordB.Count(); j++)
                {
                    // The letters matchd
                    if (wordA[i] == wordB[j])
                    {
                        if (i > 0 && j > 0)
                        {
                            cell[i, j] = cell[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            cell[i, j] = 1;
                        }
                    }
                    else
                    {
                        // The letters don't match.
                        if (i == 0 && j > 0)
                        {
                            cell[i, j] = cell[i, j - 1];
                        }
                        else if (i > 0 && j == 0)
                        {
                            cell[i, j] = cell[i - 1, j];
                        }
                        else if (i > 0 && j > 0)
                        {
                            cell[i, j] = Math.Max(cell[i - 1, j], cell[i, j - 1]);
                        }
                        else
                        {
                            cell[i, j] = 0;
                        }
                    }
                }
            }
        }
    }
}
