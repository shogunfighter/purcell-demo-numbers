using MissingNumberApp.Interfaces;

namespace MissingNumberApp.Services
{
    public class MissingNumberService
    {
        private readonly IMissingNumberFinder _missingNumberFinder;

        public MissingNumberService(IMissingNumberFinder missingNumberFinder)
        {
            _missingNumberFinder = missingNumberFinder;
        }

        public void Run()
        {
            Console.WriteLine("Enter numbers separated by commas:");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

            int missingNumber = _missingNumberFinder.FindMissingNumber(numbers);
            Console.WriteLine($"Missing number: {missingNumber}");
        }
    }
}