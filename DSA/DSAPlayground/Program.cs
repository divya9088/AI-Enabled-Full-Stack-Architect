// See https://aka.ms/new-console-template for more information
using DSAPlayground.Problems;

Console.WriteLine("Hello, World!");

int[] arr1 = [3, 7, 1, 9, 6];

int n = int.Parse(Console.ReadLine()!);
int[] arr = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
Console.WriteLine($"Max = {Find_maximum_element_in_array.MaxElemant(arr)}");
