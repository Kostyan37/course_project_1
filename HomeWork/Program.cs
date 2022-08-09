Console.Clear();

string[] array = { "hello", "2", "world", ":-)" };
string[] nearr = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        newarr[i] = array[i];
    Console.Write($"{newarr[i]} ");
}
