namespace InterfaceHW { 

public class Array : ICalc
{
    private int[] elements;

    public Array(int[] input)
    {
        this.elements = input;
    }

    public int countlessthan(int compareValue)
    {
        int count = 0;
        foreach (var item in elements)
        {
            if (item < compareValue)
                count++;
        }
        return count;
    }

    public int countgreaterthan(int compareValue)
    {
        int count = 0;
        foreach (var item in elements)
        {
            if (item > compareValue)
                count++;
        }
        return count;
    }
}
}