public class Day4
{
    public Day4()
    {

    }

    public void Puzzle1()
    {
        Console.WriteLine("Day 4 - Puzzle 1");
    }
}

public class BingoCard
{
    private BingoNumber[][] _bingoNumbers;

    public BingoCard(string[] cardNubmers)
    {
        
    }
}

public class BingoNumber
{
    private int _number;
    private bool _marked;
    public int Number {get{return _number;}}
    public bool Marked {get{return _marked;}}

    public BingoNumber(int number)
    {
        _number = number;
        _marked = false;
    }

    public void MarkNumber()
    {
        _marked = true;
    }
}