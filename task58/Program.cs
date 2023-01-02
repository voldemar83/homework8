void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,4:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] MultArrays (int[,] a, int[,] b)
{
    var dim0 = a.GetLength(0);
    var dim1 = b.GetLength(1);
    if (dim0 != dim1)
    {
        Console.WriteLine("Массивы не согласованы");
        Environment.Exit(0);
    }

    int[,] c = new int[dim0, dim1];

    for (int i = 0; i < dim0; i++)
        for (int j = 0; j < dim1; j++)
            for (int x = 0; x < a.GetLength(1); x++)
                c[i, j] += a[i, x] * b[x, j];

    return c;
}

int[,] arr0 =
{
    { 2, 4 },
    { 3, 2 }
};

int[,] arr1 =
{
    { 3, 4 },
    { 3, 3 }
};

Console.WriteLine("Первая матрица:");
PrintArray(arr0);
Console.WriteLine("Вторая матрица:");
PrintArray(arr1);
Console.WriteLine("Результат произведения матриц:");
PrintArray(MultArrays(arr0, arr1));