public class ParameterDemo
{
    // ref parameter method
    public void Increase(ref int number)
    {
        number += 10;
    }

    // out parameter method
    public void GetFullName(out string fullname)
    {
        fullname = "John Smith";
    }

    // params parameter method
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}