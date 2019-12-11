using System;
class Program
{
    public static void Main()///This C# program is used to find the length of the jagged array using predefined functions. A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes.///
    {
        byte[][] numbers = new byte[5][];
        for (int i = 0; i < numbers.Length; i++)////For loop is used to assign an element value starting with 3 for an array. Hence another for loop is used to print the elements of an array.///
        {
            numbers[i] = new byte[i + 3];
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, numbers[i].Length);
        }
        Console.Read();
    }
}
////Output:  
////Length of row 0 is 3
////Length of row 1 is 4
////Length of row 2 is 5
////Length of row 3 is 6
////Length of row 4 is 7