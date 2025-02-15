
namespace Calc
{
	internal class Calculator
	{
		private int[] _numbers = new int[2];
		private string _operation = "";

		/// <summary>
		/// Добавление числа в лист
		/// </summary>
		/// <param name="id">номер числа</param>
		public void SetNumber(int id)
		{
			int number;
			while (true)
			{
				Console.Write($"Введите {id} число: ");
				if (int.TryParse(Console.ReadLine(), out number))
				{
					_numbers[id] = number;
					return;
				}
				Console.WriteLine("Ошибка: введите корректное число!");
			}
		}
		
		/// <summary>
		/// Установка значения оператора
		/// </summary>
		public void SetOperator()
		{
			string[] validOperators = { "+", "-", "*", "/" };
			while (true)
			{
				Console.Write("Введите оператор (+, -, *, /): ");
				string? op = Console.ReadLine();
				if (validOperators.Contains(op))
				{
					_operation = op;
					return;
				}
				Console.WriteLine("Ошибка: неверный оператор!");
			}
		}

		/// <summary>
		/// Подсчет установленной операции
		/// </summary>
		/// <returns></returns>
		/// <exception cref="DivideByZeroException">Ошибка деления на ноль</exception>
		/// <exception cref="InvalidOperationException">default</exception>
		public double Calculate()
		{
			switch (_operation)
			{
				case "+":
					return _numbers[0] + _numbers[1];
				case "-":
					return _numbers[0] - _numbers[1];
				case "*":
					return _numbers[0] * _numbers[1];
				case "/":
					if (_numbers[1] == 0)
					{
						throw new DivideByZeroException("Деление на ноль!");
					}
					else
					{
						return (double)_numbers[0] / _numbers[1];
					}
				default:
					throw new InvalidOperationException("Неверный оператор!");
			}
		}
	}
}
