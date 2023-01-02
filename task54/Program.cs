void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};
Console.WriteLine("Исходный массив:");
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    int[] row = Enumerable.Range(0, arr.GetUpperBound(1)+1).Select(x => arr[i, x]).ToArray();
    Array.Sort(row);
    Array.Reverse(row);
    for (int j = 0; j < row.Length; j++)
        arr[i, j] = row[j];
}

Console.WriteLine("Отсортированные строки в массиве:");
PrintArray(arr);
