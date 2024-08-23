Console.WriteLine("Введите сумму счета:");
double billAmount;
if (!double.TryParse(Console.ReadLine(), out billAmount) || billAmount <= 0)
{
    Console.WriteLine("Ошибка ввода данных");
}

Console.WriteLine("Введите процент чаевых:");
double tipPercen;
if (!double.TryParse(Console.ReadLine(), out tipPercen) || tipPercen <= 0)
{
    Console.WriteLine("Ошибка ввода данных");
}

Console.WriteLine("Кол-во человек в группе:");
double numberOfPeople;
if (!double.TryParse(Console.ReadLine(), out numberOfPeople) || numberOfPeople <= 0)
{
    Console.WriteLine("Ошибка ввода данных");
}

double tipAmount = (billAmount * tipPercen) / 100; ;
double totalAmount = Convert.ToDouble(billAmount) + Convert.ToDouble(tipAmount);
double perPersonAmount = totalAmount / numberOfPeople;

Console.WriteLine($"Общий счет: {totalAmount}р.");
Console.WriteLine($"Процент чаевых: {tipPercen}%");
Console.WriteLine($"С каждого: {perPersonAmount}р.");

