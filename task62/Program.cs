static void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,4:00.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int side = 4;

int[,] arr = new int[side, side];
int idx = 0;

for (int x = 0; (x <= side / 2); x++)
{
    for (int i = x; i < side - x; i++)
        arr[x, i] = ++idx;

    for (int i = x + 1; i < side - x; i++)
        arr[i, side - 1 - x] = ++idx;

    for (int i = side - 2 - x; i >= 0 + x; i--)
        arr[side - 1 - x, i] = ++idx;

    for (int i = side - 2 - x; i > 0 + x; i--)
        arr[i, x] = ++idx;
}

PrintArray(arr);
