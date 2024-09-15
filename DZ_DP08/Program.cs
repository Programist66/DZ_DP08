using DZ_DP08;

Oven oven = new Oven();
while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Показать состояние духовки");
    Console.WriteLine("2. Включить духовку");
    Console.WriteLine("3. Включить духовку с таймером");
    Console.WriteLine("4. Выключить духовку");
    Console.WriteLine("5. Выйти");

    Int32.TryParse(Console.ReadLine(), out int choice);
    int temperature;
    float minutes;
    switch (choice)
    {
        case 1:
            Console.WriteLine();
            Console.WriteLine(oven);
            break;
        case 2:
            Console.Write("Введите температуру (180-240°C): ");
            Int32.TryParse(Console.ReadLine()!, out temperature);
            oven.TurnOn(temperature);
            break;
        case 3:
            Console.Write("Введите время в минутах: ");
            float.TryParse(Console.ReadLine()!, out minutes);
            Console.WriteLine(minutes);
            oven.SetTimer(minutes);
            break;
        case 4:
            oven.TurnOff();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }

    Console.WriteLine();
}