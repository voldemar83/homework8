int x = 2;
int y = 2;
int z = 2;

int[,,] arr = new int[x, y, z];
Random rand = new();

bool NumExists(int num)
{
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int t = 0; t < z; t++)
                if (arr[i, j, t] == num) return true;
    return false;
}

for (int i = 0; i < x; i++)
    for (int j = 0; j < y; j++)
        for (int t = 0; t < z; t++)
        {
            int num;
            do
            {
                num = rand.Next(10, 99);
            } while (NumExists(num));
            arr[i, j, t] = num;
        }

for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int t = 0; t < z; t++)
            Console.Write(String.Format("{0,4:0.#}", arr[i, j, t]) + $" ({i}, {j}, {t})");
        Console.WriteLine();
    }
}


