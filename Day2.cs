public class Day2 
{
    private string[] posLines;
    public Day2()
    {
        Console.WriteLine("Reading Positioning Instructions from file day2-puzzle1");

        posLines = System.IO.File.ReadAllLines("day2-puzzle1");

        Console.WriteLine("Read lines into string array");
        Console.WriteLine("Line Count: {0}", posLines.Length);
    }
    public void Puzzle1()
    {
        Console.WriteLine("Day 2 - Puzzle 1");        

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
    }

    public void Puzzle2()
    {
        Console.WriteLine("Day 2 - Puzzle 2");

        Console.WriteLine("Calculating Horizontal, Depth, and Aim Positions based on new rules");

        int horPos = 0, depthPos = 0, aimPos = 0;

        foreach(string line in posLines)
        {
            string[] subs = line.Split(' ');

            int posValue = Convert.ToInt32(subs[1]);

            switch(subs[0])
            {
                case "forward":
                    horPos += posValue;
                    depthPos += (posValue * aimPos);
                    break;
                case "down":
                    aimPos += posValue;
                    break;
                case "up":
                    aimPos -= posValue;
                    break;
                default:
                    Console.WriteLine("Something went wrong and we hit the default use case");
                    break;
            }
        }

        Console.WriteLine("Horizontal Position: {0}", horPos);
        Console.WriteLine("Depth Position: {0}", depthPos);
        Console.WriteLine("Aim Position: {0}", aimPos);

        int finalDepth = horPos * depthPos;

        Console.WriteLine("Final Position (Horizontal Position x Depth Position): {0}", finalDepth);
    }
}