using System.Text;

public class Day3
{
    private string[] diagnosticLines;

    public Day3()
    {
        Console.WriteLine("Reading Diagnostic Binary lines from file day3-puzzl1");

        diagnosticLines = System.IO.File.ReadAllLines("day3-puzzle1");

        Console.WriteLine("Read lines into string array");
        Console.WriteLine("Line Count: {0}", diagnosticLines.Length);
    }

    public void Puzzle1()
    {
        Console.WriteLine("Day 3 - Puzzle 1");

        int[] countOfOnes = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] countOfZeros = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        foreach(string line in diagnosticLines)
        {
            // Console.WriteLine("Line of bits: {0}", line);
            for(int count = 0; count < line.Length; count++)
            {
                char character = line[count];
                // Console.WriteLine("Character: {0}", character);
                
                switch(character)
                {
                    case '0':
                        countOfZeros[count] += 1;
                        break;
                    case '1':
                        countOfOnes[count] += 1;
                        break;
                    default:
                        Console.WriteLine("Something is wrong. We got to a default case in a switch statement that shouldn't have happened.");
                        break;
                }
                
            }
        }

        Console.WriteLine("Count of ones array: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", countOfOnes[0], countOfOnes[1], countOfOnes[2], countOfOnes[3], countOfOnes[4], countOfOnes[5], countOfOnes[6], countOfOnes[7], countOfOnes[8], countOfOnes[9], countOfOnes[10], countOfOnes[11]);
        Console.WriteLine("Count of zeors array: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}", countOfZeros[0], countOfZeros[1], countOfZeros[2], countOfZeros[3], countOfZeros[4], countOfZeros[5], countOfZeros[6], countOfZeros[7], countOfZeros[8], countOfZeros[9], countOfZeros[10], countOfZeros[11]);

        StringBuilder gammaRateBinary = new StringBuilder(), epsilonRateBinary = new StringBuilder();

        for(int count = 0; count < countOfOnes.Length; count++)
        {
            if(countOfOnes[count] > countOfZeros[count])
            {
                gammaRateBinary.Append("1");
                epsilonRateBinary.Append("0");
            }
            else
            {
                gammaRateBinary.Append("0");
                epsilonRateBinary.Append("1");
            }
        }

        Console.WriteLine("Gamma Rate in Binary: {0}", gammaRateBinary.ToString());
        Console.WriteLine("Epsilon Rate in Binary: {0}", epsilonRateBinary.ToString());

        double gammaRate = ConvertStringOfBitsToInteger(gammaRateBinary.ToString());
        double epsilonRate = ConvertStringOfBitsToInteger(epsilonRateBinary.ToString());

        Console.WriteLine("Gamma Rate: {0}", gammaRate);
        Console.WriteLine("Epsilon Rate: {0}", epsilonRate);

        double powerConsumption = gammaRate * epsilonRate;

        Console.WriteLine("Power Consumption: {0}", powerConsumption);
    }

    public double ConvertStringOfBitsToInteger(string bits)
    {
        double returnValue = 0;

        for(int count = 0; count < bits.Length; count++)
        {
            if(bits[count] == '1')
            {
                double power = bits.Length - 1 - count;

                double value = Math.Pow(2,power);

                returnValue += value;
            }
        }

        return returnValue;
    }

    public void Puzzle2()
    {
        Console.WriteLine("Day 3 - Puzzle 2");
        Console.WriteLine("Searching for Oxygen Generator Rating");

        List<string> diagnosticLinesList = new List<string>(diagnosticLines);

        int index = 0;

        while(diagnosticLinesList.Count != 1)
        {
            List<string> filteredList; 

            double count = diagnosticLinesList.FindAll(x => x[index] == '1').Count;

            double half = diagnosticLinesList.Count / 2.0d;

            Console.WriteLine("There are {0} ones at index {1} and a total of {2} values in the list.", count, index, diagnosticLinesList.Count);
            
            if(count > half || count == half)
            {
                Console.WriteLine("\tTake the list of more ones");
                filteredList = diagnosticLinesList.FindAll(x => x[index] == '1');
            }
            else
            {
                Console.WriteLine("\tTake the list of more zeors");
                filteredList = diagnosticLinesList.FindAll(x => x[index] == '0');
            }

            diagnosticLinesList = filteredList;
            index++;
        }

        Console.WriteLine("The last value in the list is {0}", diagnosticLinesList[0]);
        double oxygenGeneratorRating = ConvertStringOfBitsToInteger(diagnosticLinesList[0]);
        Console.WriteLine("Oxygen Generator Rating: {0}", oxygenGeneratorRating);

        Console.WriteLine("Searching for CO2 Scrubber Rating");
        diagnosticLinesList = new List<string>(diagnosticLines);

        index = 0;

        while(diagnosticLinesList.Count != 1)
        {
            List<string> filteredList;

            double count = diagnosticLinesList.FindAll(x => x[index] == '0').Count;

            double half = diagnosticLinesList.Count / 2.0d;

            Console.WriteLine("There are {0} zeros at index {1} and a total of {2} values in the list.", count, index, diagnosticLinesList.Count);

            if(count < half || count == half)
            {
                Console.WriteLine("\tTake the list of more zeros");
                filteredList = diagnosticLinesList.FindAll(x => x[index] == '0');
            }
            else
            {
                Console.WriteLine("\tTake the list of more ones");
                filteredList = diagnosticLinesList.FindAll(x => x[index] == '1');
            }

            diagnosticLinesList = filteredList;
            index++;
        }

        Console.WriteLine("The last value in the list is {0}", diagnosticLinesList[0]);
        double co2ScrubberRating = ConvertStringOfBitsToInteger(diagnosticLinesList[0]);
        Console.WriteLine("CO2 Scrubber Rating: {0}", co2ScrubberRating);

        double lifeSupportRating = oxygenGeneratorRating * co2ScrubberRating;

        Console.WriteLine("Life Support Rating: {0}", lifeSupportRating);
    }
}
