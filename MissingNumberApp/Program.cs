using MissingNumberApp.Interfaces;
using MissingNumberApp.Services;
using System;

class Program {
    static void Main()
    {
        // This variant will check for 1 missing number and display only 1 missing number
        // This will throw errors when multiple missing numbers are found / non are found
        IMissingNumberFinder finder = new MissingNumberFinder();
        MissingNumberService service = new MissingNumberService(finder);
        service.Run();

        // // This variant will check for any missing numbers and display those missing number
        // // This will throw errors non are found
        // IMissingNumbersFinder finder = new MissingNumbersFinder();
        // MissingNumbersService service = new MissingNumbersService(finder);
        // service.Run();
    }
}
