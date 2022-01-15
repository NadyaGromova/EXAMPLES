int[] array = { 11, 2, 3, 4, 82, 52, 46, 37, 82 };

int n = array.Length;
int find = 82;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
