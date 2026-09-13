public abstract class SearchAlgorithm
{
    protected int[] numbers;

    public SearchAlgorithm(int[] _numbers)
    {
        numbers = _numbers;
    }

    public abstract int Search(int target);

    protected void PrintMessage(string message)
    {
    System.Console.WriteLine(message);
    }

    public void PrintResult(int index, int target)
    {
        if (index == -1)
        {
             PrintMessage($"{target} bulunamadi.\n");
        }
        else
        {
            PrintMessage($"{target}, {index}. indekste bulundu.\n");
        }
    }
}