// See https://aka.ms/new-console-template for more information
Console.WriteLine("Advent of Code 2021");

int daysAvailable = 2;

Console.WriteLine("Which Advent of Code Day would you like to see the results? (1 to {0})", daysAvailable);

// string? inputDay = Console.ReadLine();

// if(inputDay == null)
// {
//     Console.WriteLine("You must enter a number between 1 and {0}", daysAvailable);
// }
// else
// {
    int day = 2; //Convert.ToInt32(inputDay);
    switch(day)
    {
        case 1:
            Console.WriteLine("Day 1 - Puzzle 1");
            Console.WriteLine("Reading sonar depths from file day1-puzzle1");

            string[] lines = System.IO.File.ReadAllLines("day1-puzzle1");

            Console.WriteLine("Read lines into string array");
            Console.WriteLine("Line count: {0}", lines.Length);

            Console.WriteLine("Convert strings to integers");
            List<int> depths = new List<int>();
            foreach(string line in lines)
            {
                var depth = Convert.ToInt32(line);
                depths.Add(depth);
            }

            Console.WriteLine("Counting the number of depth increases");

            int depthIncreases = 0;

            for(int count = 1; count < depths.Count; count++)
            {
                if(depths[count] > depths[count-1])
                {
                    depthIncreases++;
                }
            }

            Console.WriteLine("Depth increases: {0}", depthIncreases);

            Console.WriteLine("Day 1 - Puzzle 2");

            Console.WriteLine("Create List of three-measurement sliding window");

            List<int> slidingwindow = new List<int>();

            for(int count = 2; count < depths.Count; count++)
            {
                int sum = depths[count] + depths[count-1] + depths[count-2];
                slidingwindow.Add(sum);
            }

            Console.WriteLine("Counting the number of depth increases among the threa-measurement sliding window");

            int increases = 0;

            for(int count = 1; count < slidingwindow.Count; count++)
            {
                if(slidingwindow[count] > slidingwindow[count-1])
                {
                    increases++;
                }
            }

            Console.WriteLine("Three-measurement sliding window depth increases: {0}", increases);
            break;
        case 2:
            Console.WriteLine("Day 2 - Puzzle 1");

            Console.WriteLine("Reading Positioning Instructions from file day2-puzzle1");

            string[] posLines = System.IO.File.ReadAllLines("day2-puzzle1");

            Console.WriteLine("Read lines into string array");
            Console.WriteLine("Line Count: {0}", posLines.Length);

            Console.WriteLine("Calculating Horizontal and Depth Positions");

            int horPos = 0, depthPos = 0;

            foreach(string line in posLines)
            {
                string[] subs = line.Split(' ');

                int posValue = Convert.ToInt32(subs[1]);

                switch(subs[0])
                {
                    case "forward":
                        horPos += posValue;
                        break;
                    case "down":
                        depthPos += posValue;
                        break;
                    case "up":
                        depthPos -= posValue;
                        break;
                    default:
                        Console.WriteLine("Something went wrong and we hit the default positional use case");
                        break;
                }
            }

            Console.WriteLine("Horizontal Position: {0}", horPos);
            Console.WriteLine("Depth Position: {0}", depthPos);

            int finalDepth = horPos * depthPos;

            Console.WriteLine("Final Position (Horizontal Position x Depth Position): {0}", finalDepth);
        break;
        default:
            Console.WriteLine("You must enter a number between 1 and {0}", daysAvailable);
        break;
    }
// }

