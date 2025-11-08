using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN (step-by-step):
        // 1. Create a new array of doubles with size equal to 'length'.
        // 2. Use a for-loop to fill each position in the array.
        // 3. For index i, the value should be (i + 1) * number:
        //      - at i = 0 → number * 1 (the starting number)
        //      - at i = 1 → number * 2
        //      - ...
        // 4. After the loop finishes, return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN (step-by-step):
        // 1. If the list has 0 or 1 elements, there is nothing to rotate, so just return.
        // 2. Compute the effective rotation in case 'amount' equals the list size:
        //      effective = amount % data.Count.
        // 3. Find the index where the split happens for the right rotation:
        //      splitIndex = data.Count - effective.
        // 4. Take the last 'effective' elements (from splitIndex to end) as one list segment.
        // 5. Take the first part (from index 0 to splitIndex - 1) as the second segment.
        // 6. Clear the original list.
        // 7. Add the last segment first, then add the first segment after it.
        // 8. The original 'data' list is now rotated in-place to the right.

        if (data == null || data.Count <= 1)
        {
            return;
        }

        int count = data.Count;
        int effective = amount % count;

        if (effective == 0)
        {
            return;
        }

        int splitIndex = count - effective;

        List<int> tail = data.GetRange(splitIndex, effective);   // last 'effective' elements
        List<int> head = data.GetRange(0, splitIndex);           // elements before that

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
