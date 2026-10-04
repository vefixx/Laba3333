using System.Text;

namespace Laba3;

public class Solutions
{
    public Solutions()
    {
    }

    public int SumLastNums(int x)
    {
        var a = x % 10; // 4568 --%10--> 8
        var b = x / 10 % 10; // 4568 --/10--> 456 --%10--> 6
        return a + b;
    }

    public bool IsPositive(int x)
    {
        if (x >= 0)
        {
            return true;
        }

        return false;
    }

    public bool IsUpperCase(char x)
    {
        const string UpperAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (UpperAlph.Contains(x))
        {
            return true;
        }

        return false;
    }

    public bool IsDivisor(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
        {
            return true;
        }

        return false;
    }

    public int LastNumSum(int a, int b)
    {
        return a % 10 + b % 10;
    }

    public double SafeDiv(int x, int y)
    {
        if (y == 0)
        {
            return 0;
        }

        return x / (double)y;
    }

    public string MakeDecision(int x, int y)
    {
        if (x == y)
        {
            return $"{x}=={y}";
        }

        if (x > y)
        {
            return $"{x}>{y}";
        }

        return $"{x}<{y}";
    }

    public bool Sum3(int x, int y, int z)
    {
        if (x + y == z
            || x + z == y
            || z + y == x)
        {
            return true;
        }

        return false;
    }

    public string Age(int x)
    {
        if (x % 10 == 1 && x != 11)
        {
            return $"{x} год";
        }

        if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4)
            && (x != 12 && x != 13 && x != 14))
        {
            return $"{x} года";
        }

        return $"{x} лет";
    }

    public void PrintDays(string x)
    {
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "вторник":
                Console.WriteLine("вторник");
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "среда":
                Console.WriteLine("среда");
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "четверг":
                Console.WriteLine("четверг");
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "пятница":
                Console.WriteLine("пятница");
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "суббота":
                Console.WriteLine("суббота");
                Console.WriteLine("воскресенье");
                break;
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    public string ReverseListNums(int x)
    {
        var stringBuilder = new StringBuilder(x + 1);
        for (var i = x; i >= 0; i--)
        {
            stringBuilder.Append(i);

            if (i > 0)
            {
                stringBuilder.Append(' ');
            }
        }

        return stringBuilder.ToString();
    }

    public int Pow(int x, int y)
    {
        if (y == 0)
        {
            return 1;
        }

        var result = 1;

        for (var i = 1; i <= y; i++)
        {
            result *= x;
        }

        return result;
    }

    public bool EqualNum(int x)
    {
        var equal = true;
        var last = x % 10;
        x /= 10;

        while (x != 0 && equal)
        {
            if (x % 10 == last)
            {
                x /= 10;
            }
            else
            {
                equal = false;
            }
        }

        return equal;
    }

    public void LeftTriangle(int x)
    {
        for (var i = 0; i < x; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    public void GuessGame()
    {
        var attempts = 1;

        var random = new Random();
        var randomInt = random.Next(0, 10);

        Console.Write("Введите число от 0 до 9 включительно (или -1 для выхода): ");

        while (true)
        {
            var userNumString = Console.ReadLine();

            int userNum;

            if (!int.TryParse(userNumString, out userNum))
            {
                Console.WriteLine($"");
                continue;
            }

            if (userNum == -1)
            {
                Console.WriteLine("Вы вышли");
                return;
            }

            if (userNum == randomInt)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine($"Вы отгадали число за {attempts} попытки");
                break;
            }

            Console.Write("Вы не угадали, введите число от 0 до 9 включительно (или -1 для выхода): ");
            attempts++;
        }
    }
}
