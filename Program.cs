// Part 1
// class Program
// {
//     static void Main()
//     {
//         List<string> students = ["Иван", "Пётр", "Анна"];

//         Console.WriteLine($"Количество студентов: {students.Count}");

//         students.Add("Мария");
//         students.Remove("Пётр");

//         Console.WriteLine($"Первый студент: {students[0]}");

//         Console.WriteLine(students.Contains("Анна") ? "Есть" : "Нет");

//         foreach (string student in students)
//         {
//             Console.WriteLine(student);
//         }
//     }
// }
/*
students[0] работает точно также как и numbers[0] в массиве, оба прит обращении получают элемент с индексом 0
*/


// Part 2
// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, double> prices = new()
//         {
//             ["Хлеб"] = 45.5,
//             ["Молоко"] = 89
//         };

//         prices["Яйца"] = 120;
//         prices["Сыр"] = 350;

//         Console.WriteLine(prices["Хлеб"]);

//         prices["Хлеб"] = 50;
//         prices["Кофе"] = 450;

//         Console.WriteLine(prices.Count);
//         Console.WriteLine(prices.ContainsKey("Молоко"));

//         string product = Console.ReadLine()!;

//         if (prices.TryGetValue(product, out double price))
//         {
//             Console.WriteLine(price);
//         }
//         else
//         {
//             Console.WriteLine("Товар не найден");  
//         }
//         foreach (var pair in prices)
//         {
//             Console.WriteLine($"{pair.Key}: {pair.Value}");
//         }
//         /*
//         Console.WriteLine(prices["Несуществующий товар"]); возникает KeyNotFoundException, отсюда
//         TryGetValue безопаснее при поиске отсутствующего ключа
//         */
//     }
// }

// Part 3
// class Program
// {
//     static void Main()
//     {
//         string[] input = ["C#", "Git", "C#", "SQL", "Git", "C#"];

//         HashSet<string> tags = [];

//         foreach (string item in input)
//         {
//             tags.Add(item);
//         }
//         Console.Write("Enter a technology: ");
//         string technology = Console.ReadLine()!;

//         if (tags.Contains(technology))
//             Console.WriteLine("Technology found");
//         else
//             Console.WriteLine("Technology not found");
//     }
// }

// Part 4
/*
1. Коллекция
List<string>
Причина - товары можно добавлять и удалять

2. Коллекция
Dictionary<string, string>
Причина - номер телефона находится по уникальному имени

3. Коллекция
HashSet<string>
Причина: набор хранит только уникальные теги
*/