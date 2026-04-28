
//Task 1. Arrayin ededlerinin cemi
int[] numbers = { 2, 34, 14, 35, 86, 17, 58, 90 }
;

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}
Console.WriteLine(sum);

//Task 2. Arrayda nece denen tek eded oldugunu hesabla

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        count++;
    }
    else continue;
}
Console.WriteLine(count);

Array.Sort(numbers);
Array.Reverse(numbers);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

//Terkibinde a herfi olan adlari capa cixar
string[] names = { "Ali", "Arzu", "Namiq", "Kemale", "Nigar", "Leyla", "Isa" };
for (int i = 0; i < names.Length; i++)
{
    if (names[i].ToLower().Contains("a")) Console.Write($"{names[i]}, ");
}

//En uzun sozun uzunlugunu capa cixar.
int maxLength = 0;
for (int i = 0; i < names.Length; i++)
{
    if (names[i].Length > maxLength) maxLength = names[i].Length;
}
Console.WriteLine(maxLength);
