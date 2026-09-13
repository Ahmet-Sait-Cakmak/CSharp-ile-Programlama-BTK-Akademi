public class LinearSearch : SearchAlgorithm
{
    public LinearSearch(int[] _sayiDizisi) : base(_sayiDizisi)
    {
        
    }
    public override int Search(int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
                return i;
        }

        return -1;
    }
}