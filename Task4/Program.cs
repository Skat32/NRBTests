const string text = "BBCACCBXCBA";

// Подсчет символов "A" с заданным контекстом
var count = CountAWithContext(text);

// Вывод результата
Console.WriteLine("Количество символов 'A' с контекстом: " + count);
return;

static int CountAWithContext(string text)
{
    var count = 0;
    
    for (var i = 3; i < text.Length; i++)
        if (text[i] == 'A' && text[i - 3] == 'B' && text[i + 1] == 'C')
            count++;
    
    return count;
}