int[] Change(int[] arr1, int[] arr2)
{
    int temp = 0;
    int[] NewArr = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i == 0)
        {
            for(int j = 0; j < arr1[i]; j++)
            {
                NewArr[i] = NewArr[i] + arr2[j] * Convert.ToInt32(Math.Pow(2, arr1[i] - (j + 1)));
            }
        }
        else
        {
            for(int j = 0; j < arr1[i]; j++)
            {
                NewArr[i] = NewArr[i] + arr2[j + temp] * Convert.ToInt32(Math.Pow(2, arr1[i] - (j + 1)));
            }
        }
        temp = temp + arr1[i];
    }
    return NewArr;
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

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1};

int[] NewArray = Change(info, data);
PrintArray(NewArray);