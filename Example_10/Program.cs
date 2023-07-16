int[] array = { 11, 21, 31, 43, 15, 64, 27, 58, 98, 39, 64 };
int n = array.Length;
int find = 64;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;

}