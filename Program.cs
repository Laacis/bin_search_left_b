 static int FindLeftBorder(long[] arr, long value)
{
	return BinSearchLeftBorder(arr, value, -1, arr.Length);
}

static int BinSearchLeftBorder(long[] array, long value, int left, int right)
{
    if (left - right == 1) return left;
    var m = (left + right) / 2;
    if (array[m] < value)
        return BinSearchLeftBorder(array, value, m, right);
    return BinSearchLeftBorder(array, value, left, m);
}

long[] task = new long[] { 2, 4, 4, 6 };

Console.WriteLine(FindLeftBorder(task, 1));