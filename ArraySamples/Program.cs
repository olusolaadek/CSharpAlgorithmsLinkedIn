using System.Collections;

int[] nums = { 3, 5, 1, 6, 8, 5 };
// Array.Fill(nums, 3);

// Array.ForEach(nums, i => { Console.WriteLine(i); });
// Array.ForEach(nums, Console.WriteLine);

//Console.WriteLine(Array.Exists(nums, d => d == 5));
//Console.WriteLine(Array.Find(nums, d => d == 6));
//Console.WriteLine(Array.Find(nums, d => d == 5));
//Console.WriteLine(Array.FindAll(nums, d => d == 4).Length);
//Console.WriteLine(Array.FindAll(nums, d => d == 5).Length);
int[] arr = { 1, 2, 3, 4, 5 };
//Console.WriteLine(BinarySearch(arr, 4));
//Console.WriteLine(BinarySearch(arr, 7));
int[] arr1 = { 1, 2, 3, 4, 5 };
int[] arr2 = { 5, 6, 7, 8, 9, 10 };
//var result = FindEvenNums(arr1, arr2);

//Console.WriteLine("Even nuns: ");
//Array.ForEach(result, Console.Write);
var leftRotated = RotateLeft(arr);
Array.ForEach(leftRotated, Console.WriteLine);
var rightRotated = RotateRight(arr);
Array.ForEach(rightRotated, Console.WriteLine);

static int[] RotateRight(int[] arr)
{

    int last = arr[arr.Length - 1];
    //
    for (int i = arr.Length - 1; i > 0; i--)
    {
        arr[i] = arr[i - 1];
    }
    arr[0] = last;
    return arr;

}
static int[] RotateLeft(int[] arr)
{
    int first = arr[0];


    for (int i = 0; i < arr.Length - 1; i++)
    {

        arr[i] = arr[i + 1];
    }
    arr[arr.Length - 1] = first;
    return arr;
}

static int[] FindEvenNums(int[] arr1, int[] arr2)
{
    ArrayList result = new ArrayList();
    var r1 = Array.FindAll(arr1, d => d % 2 == 0);
    var r2 = Array.FindAll(arr2, d => d % 2 == 0);
    result.AddRange(r1);
    result.AddRange(r2);
    return (int[])result.ToArray(typeof(int));

    //foreach (var n in arr1)
    //{
    //    if (n % 2 == 0)
    //    {

    //    }
    //}
}
static bool BinarySearch(int[] inputArray, int item)
{
    int min = 0;
    int max = inputArray.Length - 1;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (item == inputArray[mid])
        {
            return true;
        }
        else if (item < inputArray[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return false;
}
