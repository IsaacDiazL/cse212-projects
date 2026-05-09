using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // declare a variable to store array
        var result = new double[length];
        var numDoubl = number;
        //Using For loop cycling for length variable, in each variable number variable will be double
        for(var i = 0; i < length; i++)
        {
            //store number in the list and double remain value on next loop
            result[i] = numDoubl;
            numDoubl += number;
        }


        return result; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Calculate index where list will be slice
        // Store it in a variable to use on the slice 
        int sliceIndex = data.Count - amount;

        // Get 2 lists to store the right part and left part of the list
        //1st part starts at the slice and ends at the last index number
        // 2nd part starts at index 0 and ends at slice index
        List<int> rightPart = data.GetRange(sliceIndex, amount);
        List<int> leftPart = data.GetRange(0, sliceIndex);

        // Clear list and then add the 2 parts got, starting by right part
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
        
    }
}
