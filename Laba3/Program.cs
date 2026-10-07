using System;

namespace Laba3;

class Program
{
    static void Main(string[] args)
    {
        Solutions solutions = new Solutions();
        bool isRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Задача 1.2 (Сумма двух последних цифр)");
            Console.WriteLine("2. Задача 1.4 (Проверка числа на положительность)");
            Console.WriteLine("3. Задача 1.6 (Проверка символа на верхний регистр)");
            Console.WriteLine("4. Задача 1.8 (Проверка на делитель)");
            Console.WriteLine("5. Задача 1.10 (Сумма последних цифр двух чисел)");
            Console.WriteLine("6. Задача 2.2 (Безопасное деление)");
            Console.WriteLine("7. Задача 2.4 (Сравнение двух чисел)");
            Console.WriteLine("8. Задача 2.6 (Сумма двух равна третьему)");
            Console.WriteLine("9. Задача 2.8 (Правильное склонение возраста)");
            Console.WriteLine("10. Задача 2.10 (Дни недели)");
            Console.WriteLine("11. Задача 3.2 (Обратный список чисел)");
            Console.WriteLine("12. Задача 3.4 (Возведение в степень)");
            Console.WriteLine("13. Задача 3.6 (Все цифры числа равны)");
            Console.WriteLine("14. Задача 3.8 (Левый треугольник)");
            Console.WriteLine("15. Задача 3.10 (Игра Угадай число)");
            Console.WriteLine("16. Задача 4.2 (Поиск последнего вхождения)");
            Console.WriteLine("17. Задача 4.4 (Вставка элемента в массив)");
            Console.WriteLine("18. Задача 4.6 (Реверс массива)");
            Console.WriteLine("19. Задача 4.8 (Соединение массивов)");
            Console.WriteLine("20. Задача 4.10 (Удаление отрицательных)");
            Console.WriteLine("0. Выход");
            Console.WriteLine();
            Console.Write("Выберите номер задачи: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Результат: {solutions.SumLastNums(ReadInt("Введите число: "))}");
                    break;
                case "2":
                    Console.WriteLine($"Результат: {solutions.IsPositive(ReadInt("Введите число: "))}");
                    break;
                case "3":
                    Console.WriteLine($"Результат: {solutions.IsUpperCase(ReadChar("Введите символ: "))}");
                    break;
                case "4":
                    Console.WriteLine(
                        $"Результат: {solutions.IsDivisor(ReadInt("Введите a: "), ReadInt("Введите b: "))}");
                    break;
                case "5":
                    Console.WriteLine(
                        $"Результат: {solutions.LastNumSum(ReadInt("Введите a: "), ReadInt("Введите b: "))}");
                    break;
                case "6":
                    Console.WriteLine(
                        $"Результат: {solutions.SafeDiv(ReadInt("Введите x: "), ReadInt("Введите y: "))}");
                    break;
                case "7":
                    Console.WriteLine(
                        $"Результат: {solutions.MakeDecision(ReadInt("Введите x: "), ReadInt("Введите y: "))}");
                    break;
                case "8":
                    Console.WriteLine(
                        $"Результат: {solutions.Sum3(ReadInt("Введите x: "), ReadInt("Введите y: "), ReadInt("Введите z: "))}");
                    break;
                case "9":
                    Console.WriteLine($"Результат: {solutions.Age(ReadInt("Введите возраст: "))}");
                    break;
                case "10":
                    solutions.PrintDays(ReadString("Введите день недели: "));
                    break;
                case "11":
                    Console.WriteLine($"Результат: {solutions.ReverseListNums(ReadInt("Введите число: "))}");
                    break;
                case "12":
                    Console.WriteLine($"Результат: {solutions.Pow(ReadInt("Введите x: "), ReadInt("Введите y: "))}");
                    break;
                case "13":
                    Console.WriteLine($"Результат: {solutions.EqualNum(ReadInt("Введите число: "))}");
                    break;
                case "14":
                    solutions.LeftTriangle(ReadInt("Введите размер: "));
                    break;
                case "15":
                    solutions.GuessGame();
                    break;
                case "16":
                    int[] arr16 = ReadArray("Введите массив через пробел: ");
                    Console.WriteLine(
                        $"Результат (индекс): {solutions.FindLast(arr16, ReadInt("Введите искомое число: "))}");
                    break;
                case "17":
                    int[] arr17 = ReadArray("Введите массив через пробел: ");
                    PrintArray(solutions.Add(arr17, ReadInt("Введите число для вставки: "),
                        ReadInt("Введите позицию: ")));
                    break;
                case "18":
                    int[] arr18 = ReadArray("Введите массив через пробел: ");
                    solutions.Reverse(arr18);
                    PrintArray(arr18);
                    break;
                case "19":
                    int[] arr19a = ReadArray("Введите первый массив: ");
                    int[] arr19b = ReadArray("Введите второй массив: ");
                    PrintArray(solutions.Concat(arr19a, arr19b));
                    break;
                case "20":
                    int[] arr20 = ReadArray("Введите массив через пробел: ");
                    PrintArray(solutions.DeleteNegative(arr20));
                    break;
                case "0":
                    isRunning = false;
                    Console.WriteLine("Завершение работы программы");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine("Введите любую букву для возврата в меню...");
                Console.ReadLine();
            }
        } while (isRunning);
    }

    static int ReadInt(string str)
    {
        Console.Write(str);
        int val;
        while (!int.TryParse(Console.ReadLine(), out val))
        {
            Console.Write("Ошибка. Введите целое число: ");
        }

        return val;
    }

    static char ReadChar(string str)
    {
        Console.Write(str);
        string input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.Write("Ошибка. Введите символ: ");
            input = Console.ReadLine();
        }

        return input[0];
    }

    static string ReadString(string str)
    {
        Console.Write(str);
        return Console.ReadLine();
    }

    static int[] ReadArray(string str)
    {
        Console.Write(str);

        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            return new int[0];
        }

        string[] parts = input.Split(' ');

        int[] arr = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            arr[i] = int.Parse(parts[i]);
        }

        return arr;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Результат: [" + string.Join(", ", arr) + "]");
    }
}
