string[] firstarray = new string[5] {"111", "222", "helloworld", "alohha", "bla"};
string[] secondarray = new string[firstarray.Length];

void ResultArray(string[] firstarray, string[] secondarray)
{
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
    if(firstarray[i].Length <= 3) {
        secondarray[count] = firstarray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ResultArray(firstarray, secondarray);
PrintArray(secondarray);