using MissingNumberApp.Interfaces;

namespace MissingNumberApp.Services
{
    public class MissingNumbersService
    {
        private readonly IMissingNumbersFinder _missingNumbersFinder;

        public MissingNumbersService(IMissingNumbersFinder missingNumbersFinder)
        {
            _missingNumbersFinder = missingNumbersFinder;
        }

        // public void Run()
        // {
        //     Console.WriteLine("Enter numbers separated by commas:");
        //     string input = Console.ReadLine();
        //     int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

        //     int missingNumbers = _missingNumbersFinder.FindMissingNumbers(numbers);
        //     Console.WriteLine($"Missing number: {missingNumbers}");
        // }

        public void Run()
        {
            Console.WriteLine("Enter numbers separated by commas:");
            string input = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            try
            {
                int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);
                var missingNumbers = _missingNumbersFinder.FindMissingNumbers(numbers);

                if (missingNumbers.Count == 0)
                {
                    Console.WriteLine("No missing numbers found.");
                }
                else
                {
                    Console.WriteLine($"Missing numbers: {string.Join(", ", missingNumbers)}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers separated by commas.");
            }
        }
    }
}