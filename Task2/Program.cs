void FillArray(int[] collection)
{
    int len = collection.Length;
    int i = 0;
    while (i < len)
    {
        collection[i] = i + 1;
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count - 1; pos++)
    {
        Console.Write($"{col[pos]}, ");
    }
    Console.Write($"{col[count - 1]} ");
}

void Groups(int[] arg)
{
    int cntGroup = 1;

        for (int i = 0; i < arg.Length; i++)
        {
            int count = 0;
            int[] arr = new int[arg.Length];
            for(int j = i; j < arg.Length; j++)
            {
                if (arg[j] / arg[i] == 1 || arg[j] % arg[i] != 0)
                {
                    arr[count] = arg[j];
                    count++;
                }
            }
            int temp = count;
            for (int m = count; m > 1; m--)
            {
                for (int l = count - 1; l >= 0; l--)
                {
                    if (arr[count] / arr[l] != 1 || arr[count] % arr[l] == 0)
                    {
                        arr[count] = 0;
                    }
                }
                count--;
            }
            int[] arr2 = new int[temp];
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = arr[j];
            }
            Console.Write($"Группа {cntGroup}: ");
            cntGroup++;
            PrintArray(arr2);
            Console.WriteLine();
        }

}

int[] Array = new int[10];
FillArray(Array);
Groups(Array);
