using MissingNumberApp.Interfaces;

namespace MissingNumberApp.Services
{
    public class MissingNumbersFinder : IMissingNumbersFinder
    {
        public List<int> FindMissingNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty", nameof(nums));
            }

            var missingNumbers = new List<int>();
            var numSet = new HashSet<int>(nums);
            
            // Find the maximum number in the array to determine the range
            int maxNum = nums.Max();
            
            // Check for missing numbers in the range [0, maxNum]
            for (int i = 0; i <= maxNum; i++) {
                if (!numSet.Contains(i)) {
                    missingNumbers.Add(i);
                }
            }
            
            return missingNumbers;
        }

    }
}