//Лаб 8 Средний 15
try
{
    Console.Write("Введите количество заявок: ");
    int n = int.Parse(Console.ReadLine());
    Network[] requests = new Network[n];
    for (int i = 0; i < n; i++)
    {
        if (n > 1) Console.WriteLine($"\nЗаявка {i + 1})");
        Console.Write("ФИО абонента: ");
        requests[i].fio = Console.ReadLine();
        Console.Write("Номер телефона абонента: ");
        requests[i].number = int.Parse(Console.ReadLine());
        Console.Write("Дата поломки YYYY.MM.DD: ");
        requests[i].startDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Время поломки HH:MM:SS: ");
        requests[i].startTime = TimeOnly.Parse(Console.ReadLine());
        Console.Write("Дата устранения YYYY.MM.DD: ");
        requests[i].endDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Время устранения HH:MM:SS: ");
        requests[i].endTime = TimeOnly.Parse(Console.ReadLine());
        requests[i].durationTime = (requests[i].endDate - requests[i].startDate).TotalDays;
        Console.WriteLine($"Длительность устранения неисправности в днях: {requests[i].durationTime}");
    }
    Console.WriteLine();
    Console.WriteLine("\tЗаявки на ремонт: ");
    for (int i = 0; i < requests.Length; i++)
    {
        if (n > 1) Console.WriteLine($"Заявка {i + 1})");
        Console.WriteLine($"ФИО абонента: {requests[i].fio}");
        Console.WriteLine($"Номер телефона абонента: {requests[i].number}");
        Console.WriteLine($"Длительность устранения неисправности в днях: {requests[i].durationTime}");
    }
    Console.WriteLine();
    Console.WriteLine("\tПоломки за прошлый месяц: ");
    for (int i = 0; i < n; i++)
    {
        DateTime today = DateTime.Today;
        DateTime prevMonthFirst = new DateTime(today.Year, today.AddMonths(-1).Month, 1);
        DateTime prevMonthLast = prevMonthFirst.AddMonths(1).AddDays(-1);
        if (prevMonthFirst >= requests[i].startDate || requests[i].endDate <= prevMonthLast)
        {
            if (n > 1) Console.WriteLine($"Заявка {i + 1})");
            Console.WriteLine($"ФИО абонента: {requests[i].fio}");
            Console.WriteLine($"Номер телефона абонента: {requests[i].number}");
            Console.WriteLine($"Дата поломки YYYY.MM.DD: {requests[i].startDate}");
            Console.WriteLine($"Время поломки HH:MM:SS: {requests[i].startTime}");
            Console.WriteLine($"Дата устранения YYYY.MM.DD: {requests[i].endDate}");
            Console.WriteLine($"Время устранения HH:MM:SS: {requests[i].endTime}");
            Console.WriteLine($"Длительность устранения неисправности в днях: {requests[i].durationTime}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Network
{
    public string fio;
    public int number;
    public DateTime startDate;
    public DateTime endDate;
    public TimeOnly startTime;
    public TimeOnly endTime;
    public double durationTime;
}