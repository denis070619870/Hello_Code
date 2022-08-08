// Найти элемент в массиве от 0 до n, равный find

int[] array = {34,66,66,33,67,9,5,90,18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index =index + 1;
    index++;
}