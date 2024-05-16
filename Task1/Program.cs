int[] arr = [5, 2, 9, 1, 7];

// Сортировка массива от максимума к минимуму
Array.Sort(arr, (a, b) => b - a);

// Вывод отсортированного массива
Console.WriteLine("Отсортированный массив:");
foreach (var num in arr) 
    Console.Write(num + " ");

Console.WriteLine();

// O(n log n), где n - количество элементов в массиве. Метод Array.Sort использует алгоритм быстрой сортировки (quicksort).