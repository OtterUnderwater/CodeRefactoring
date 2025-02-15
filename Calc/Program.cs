using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Введите первое число:");
		int a = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите оператор (+, -, *, /):");
		string op = Console.ReadLine();

		Console.WriteLine("Введите второе число:");
		int b = int.Parse(Console.ReadLine());

		if (op == "+")
		{
			Console.WriteLine("Результат: " + (a + b));
		}
		else if (op == "-")
		{
			Console.WriteLine("Результат: " + (a - b));
		}
		else if (op == "*")
		{
			Console.WriteLine("Результат: " + (a * b));
		}
		else if (op == "/")
		{
			if (b == 0)
			{
				Console.WriteLine("Ошибка: деление на ноль!");
			}
			else
			{
				Console.WriteLine("Результат: " + (a / b));
			}
		}
		else
		{
			Console.WriteLine("Неверный оператор!");
		}
	}
}