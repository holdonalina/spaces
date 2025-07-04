//Ви отримали рядок, який містить декілька слів, розділених комами. Ваша мета - видалити всі пробіли з цього рядка та вивести результат.

string input = "cat, dog, bird, seven, tree";
string noSpaces = input.Replace(" ", "");
Console.WriteLine(noSpaces);

