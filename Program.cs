Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());

string[] ArrayFill(int M)
{
    string[] Words = new string[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write($"{i + 1} строка: ");
        Words[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return Words;
}
string[] WordsGreatterThan3(string[] Words)
{
    int M = Words.Length;
    string[] wordsGreatterThan3 = new string[M];
    int j = 0;
    for (int i = 0; i < M; i++)
    {
        if (Words[i].Length <= 3)
        {
            wordsGreatterThan3[j] = Words[i];
            j++;
        }
    }
    Array.Resize(ref wordsGreatterThan3, j);

    return wordsGreatterThan3;
}
string[] words = ArrayFill(M);
Console.Write("[" + string.Join(",", words) + "]->");
string[] wordsGreatterThan3 = WordsGreatterThan3(words);
Console.Write("[" + string.Join(",", wordsGreatterThan3) + "]");
