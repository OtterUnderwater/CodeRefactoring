using Calc;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			Calculator calculator = new Calculator();
			calculator.SetNumber(1);
			calculator.SetOperator();
			calculator.SetNumber(2);
			Console.WriteLine($"Результат: {calculator.Calculate()}");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Ошибка: {ex.Message}");
		}
	}
}