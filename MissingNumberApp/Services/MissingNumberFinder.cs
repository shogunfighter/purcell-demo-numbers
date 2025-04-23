using MissingNumberApp.Interfaces;
using System;

namespace MissingNumberApp.Services
{
    public class MissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty", nameof(nums));
            }

            var missingNumbers = new List<int>();
            var numSet = new HashSet<int>(nums);
            
            // Find the maximum number in the array to determine the range
            int maxNum = nums.Length > 0 ? nums.Max() : 0;
            
            // Check for missing numbers in the range [0, maxNum]
            for (int i = 0; i <= maxNum; i++) {
                if (!numSet.Contains(i)) {
                    missingNumbers.Add(i);
                }
            }

            if (missingNumbers.Count == 0)
            {
                throw new InvalidOperationException("No missing numbers found in the sequence.");
            }

            if (missingNumbers.Count > 1)
            {
                throw new InvalidOperationException("Multiple missing numbers found in the sequence.");
            }

            return missingNumbers[0];
        }

    }
}