// задание 1 а)

//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Math.Cos);
//Console.WriteLine();

//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, funB);          // ссылка на статический метод
//double funB(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }
//Console.WriteLine();

//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6,
//    x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI);  // лямбда-выражение простого типа

//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>        // Лямбда-выражения блочного типа
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//});
//Console.WriteLine();

//ArifmFunc Fdel = delegate (double x)        // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Fdel);
//Console.WriteLine();

//void TabFunc(double a, double b, double step, ArifmFunc del)
//{
//    Console.WriteLine("Значения функции {3} на отрезке [{0}, {1}] с шагом {2}",
//        a, b, step, del.Method.Name);
//    for (double x = a; x <= b; x += step)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}
//delegate double ArifmFunc(double x);


// б)

//Func<double, double> fun = delegate (double x)   // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};
//void TabFunc(double a, double b, double step, Func<double, double> del)
//{
//    Console.WriteLine("значения функции {3} на отрезке [{0}, {1}] с шагом {2}",
//        a, b, step, del.Method.Name);
//    for (double x = a; x <= b; x += step)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, fun);


// в)

//double funB(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }
//Func<double, double> fun = delegate (double x)   // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] array = new Func<double, double>[]{ Math.Cos, funB,
//x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, fun };

//for (int i = 0; i < array.Length; i++)
//{
//    TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i]);
//    Console.WriteLine();
//}
//void TabFunc(double a, double b, double step, Func<double, double> del)
//{
//    Console.WriteLine("значения функции {3} на отрезке [{0}, {1}] с шагом {2}",
//        a, b, step, del.Method.Name);
//    for (double x = a; x <= b; x += step)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}


// г)

//double funB(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }
//Func<double, double> fun = delegate (double x)   // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] array = new Func<double, double>[]{ Math.Cos, funB,
//x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, fun };

//Predicate<double> IsNegative = (double num) => num < 0;
//Predicate<double> ModuleIsLess1 = (double num) => Math.Abs(num) <= 1;
//int count1 = 0, count2 = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    int c1 = TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i], IsNegative);
//    Console.WriteLine($"Количество отрицательных значений функции = {c1}\n");
//    count1 += c1;
//}
//Console.WriteLine("Всего отрицательных значений " + count1 + "\n");
//for (int i = 0; i < array.Length; i++)
//{
//    int c2 = TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i], ModuleIsLess1);
//    Console.WriteLine($"Количество значений функции из [-1; 1] = {c2}\n");
//    count2 += c2;
//}
//Console.WriteLine("Всего значений из [-1; 1] " + count2);
//int TabFunc(double a, double b, double step, Func<double, double> del, Predicate<double> check)
//{
//    int count = 0;
//    Console.WriteLine("значения функции {3} на отрезке [{0}, {1}] с шагом {2}",
//        a, b, step, del.Method.Name);
//    for (double x = a; x <= b; x += step) {
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//        if (check(del(x))) count++;
//    }
//    return count;
//}


// д)

//int[] array = new int[10];
//Random rnd = new();
//for (int i = 0; i < array.Length; i++) { array[i] = rnd.Next(-10, 11); }
//double min, max;

//double funB(double x) { return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; }
//Func<double, double> fun = delegate (double x)   // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] functions = new Func<double, double>[]{ Math.Cos, funB,
//x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, fun };

//void MaxAndMin(int[] a, Func<double, double> del, out double minimum, out double maximum)
//{
//    minimum = del(a[0]);
//    maximum = del(a[0]);
//    Console.WriteLine("Значения функции {0} на интервале [-1; 1]", del.Method.Name);
//    for (int i = 0; i < a.Length; i++)
//    {
//        Console.WriteLine("x={0}\t f(x) = {1}", a[i], del(a[i]));
//        if (del(a[i]) > maximum) maximum = del(a[i]);
//        if (del(a[i]) < minimum) minimum = del(a[i]);
//    }
//}

//for (int j = 0; j < functions.Length; j++)
//{
//    MaxAndMin(array, functions[j], out min, out max);
//    Console.WriteLine("\nМинимальное значение функции = " + min);
//    Console.WriteLine("Максимальное значение функции = " + max + "\n");
//}


// задание 2 а), б)

//int count1, count2;
//string[] arr = { "abcd46", "Abcd437", "aboba", "hello", "MadaM", "Racecar", "1234567890", "gream cream helll" };
//Console.WriteLine("Массив строк: ");
//foreach (string s in arr) Console.WriteLine(s);

//StrArr WithoutCapLetters = delegate (string[] a)
//{
//    int count = 0;
//    foreach (string str in a) {
//        bool flag = true;
//        foreach (char c in str)
//            if (c >= 'A' && c <= 'Z') { flag = false; break; }
//        if (flag) count++;
//    }
//    return count;
//};
//StrArr Palindromes = delegate (string[] a) { return a.Count(s => s.SequenceEqual(s.Reverse())); };
//StrArr TenLetterStr = delegate (string[] a) { return a.Count(s => s.Length == 10); };
//StrArr FiveLetterWords = delegate (string[] a)
//{
//    return a.Sum(s => s.Split(' ').Count(w => w.Length == 5));
//};

//void StringResearch(string[] arr, StrArr f1, StrArr f2, out int c1, out int c2)
//{
//    c1 = f1(arr);
//    c2 = f2(arr);
//}
//StringResearch(arr, WithoutCapLetters, Palindromes, out count1, out count2);

//Console.WriteLine("\nКоличество строк, в которых нет заглавных букв = " + count1);
//Console.WriteLine("Количество палиндромов в наборе = " + count2);

//StringResearch(arr, TenLetterStr, FiveLetterWords, out count1, out count2);

//Console.WriteLine("\nКоличество десятисимвольных строк в наборе = " + count1);
//Console.WriteLine("Количество пятибуквенных слов в наборе из строк = " + count2);

//delegate int StrArr(string[] arr);


// в)

using System.Globalization;
using System.Text.RegularExpressions;

List<string> res1, res2;
string[] arr = { "wreck-less Wrong dog-cat", "Warm wether today", "hello Wednesday bye-bye", "Wap-wap hihi wapwap Wh" };
Console.WriteLine("Массив строк: ");
foreach (string s in arr) Console.WriteLine(s);

StrArr StartWithW = delegate (string[] a)
{
    List<string> wordsW = new();
    foreach (string s in a)
    {
        string[] words = s.Split(' ');
        foreach (string w in words)
        {
            if (Regex.IsMatch(w, @"^W\w*")) wordsW.Add(w);
        }
    }
    return wordsW;
};

StrArr Hyphenated = delegate (string[] a)
{
    List<string> words = new();
    foreach (string s in a)
    {
        MatchCollection matches = Regex.Matches(s, @"(^|\b)[^ ]+-[^ ]+($|\b)");
        foreach (Match m in matches) words.Add(m.Value);
    }
    return words;
};

void StringResearch(string[] arr, StrArr f1, StrArr f2, out List<string> l1, out List<string> l2)
{
    l1 = f1(arr);
    l2 = f2(arr);
}

StringResearch(arr, StartWithW, Hyphenated, out res1, out res2);
Console.WriteLine("\nСлова, начинающиеся на букву 'W':");
foreach (string s in res1) Console.Write(s + " ");
Console.WriteLine("\nСоставные слова, включающие дефис");
foreach (string s in res2) Console.Write(s + " ");

delegate List<string> StrArr(string[] arr);
