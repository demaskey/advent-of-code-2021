// See https://aka.ms/new-console-template for more information
Console.WriteLine("Advent of Code 2021");

int daysAvailable = 4;

Console.WriteLine("Which Advent of Code Day would you like to see the results? (1 to {0})", daysAvailable);

// string? inputDay = Console.ReadLine();

// if(inputDay == null)
// {
//     Console.WriteLine("You must enter a number between 1 and {0}", daysAvailable);
// }
// else
// {
    int day = 4; //Convert.ToInt32(inputDay);
    switch(day)
    {
        case 1:
            Day1 day1 = new Day1();

            day1.Puzzle1();

            day1.Puzzle2();

            break;
        case 2:
            Day2 day2 = new Day2();

            day2.Puzzle1();

            day2.Puzzle2();
            break;
        case 3:
            Day3 day3 = new Day3();

            day3.Puzzle1();

            day3.Puzzle2();
            break;
        case 4:
            Day4 day4 = new Day4();

            day4.Puzzle1();
            break;
        default:
            Console.WriteLine("You must enter a number between 1 and {0}", daysAvailable);
        break;
    }
// }

