﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Advent of Code 2021");

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

Console.WriteLine("Create List of three-measurement sliding window");

List<int> slidingwindow = new List<int>();

for(int count = 2; count < depths.Count; count++)
{
    int sum = depths[count] + depths[count-1] + depths[count-2];
    slidingwindow.Add(sum);
}

Console.WriteLine("Counting the number of depth increases");

int increases = 0;

for(int count = 1; count < slidingwindow.Count; count++)
{
    if(slidingwindow[count] >slidingwindow[count-1])
    {
        increases++;
    }
}

Console.WriteLine("Depth increases: {0}", increases);