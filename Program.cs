namespace LR4_
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Station station = Station.GetInstance();
            Methods.SetData(station);

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine(new String('-', 30));
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine("1 - Изменить станцию");
                Console.WriteLine("2 - Информация о станции");
                Console.WriteLine("3 - Стоимость непроданных билетов");
                Console.WriteLine("4 - Изменение цены билета");
                Console.WriteLine("5 - Выход");

                string? answer = Console.ReadLine();
                Console.WriteLine(new String('-', 30));
                switch (answer)
                {
                    case "1":
                        Methods.SetData(station);
                        break;
                    case "2":
                        Methods.GetData(station);
                        break;
                    case "3":
                        Methods.CountCost(station);
                        break;
                    case "4":
                        Methods.ChangeCost(station);
                        break;
                    case "5":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        break;
                }
            }
        }
    }
}
