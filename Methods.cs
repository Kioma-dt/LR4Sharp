namespace LR4_
{
    static internal class Methods
    {
        public static void CountCost(Station station)
        {
            double countedCost = station.GetCostOfRemainTickets();
            Console.WriteLine($"Стоимость непроданных билетов: {countedCost}");
        }

        public static void ChangeCost(Station station)
        {
            Console.Write("Вы хотите уменьшить(0) или увеличить(1) стоимость: ");
            string? answer = Console.ReadLine();
            while (answer is not "0" and not "1")
            {
                Console.Write("Неверный пункт меню! Необходимо ввести 0 или 1: ");
                answer = Console.ReadLine();
            }

            Console.WriteLine($"Старая цена: {station.TicketCost}");
            if (answer is "0")
            {
                double decrese = 0d;
                try
                {
                    Console.Write("Насколько вы хотите уменьшить цену: ");
                    decrese = Double.Parse(Console.ReadLine() ?? String.Empty);
                    if (decrese < 0) {
                        throw new Exception("Уменьшение должно быть неотрицательым");
                    }
                    station.DecreaseTicketCost(decrese);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось уменьшить цену: {ex.Message}");
                }
            }
            else
            {
                double increse = 0d;
                try
                {
                    Console.Write("Насколько вы хотите увеличить цену: ");
                    increse = Double.Parse(Console.ReadLine() ?? String.Empty);
                    if (increse < 0)
                    {
                        throw new Exception("Увеличение должно быть неотрицательым");
                    }
                    station.IncreaseTicketCost(increse);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не удалось увеличить цену {ex.Message}");
                }
            }
            Console.WriteLine($"Новая цена: {station.TicketCost}");
        }

        public static void GetData(Station station)
        {
            Console.WriteLine($"Название: {station.Name}");
            Console.WriteLine($"Количество мест: {station.Places}");
            Console.WriteLine($"Количество проданных билетов: {station.SoldTickets}");
            Console.WriteLine($"Стоимость билета: {station.TicketCost}");
        }

        public static void SetData(Station station)
        {
            string? name = station.Name;
            uint places = station.Places, soldTickets = station.SoldTickets;
            double cost = station.TicketCost;

            try
            {
                Console.Write("Введите название станции: ");
                name = Console.ReadLine() ?? String.Empty;
                Console.Write("Введите количество мест: ");
                places = UInt32.Parse(Console.ReadLine() ?? String.Empty);
                Console.Write("Введите количество проданных билетов: ");
                soldTickets = UInt32.Parse(Console.ReadLine() ?? String.Empty);
                Console.Write("Введите стоимость билет: ");
                cost = Double.Parse(Console.ReadLine() ?? String.Empty);
                station.SetData(name, places, soldTickets, cost);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Не удалось изменить станцию: {ex.Message}");
            }
        }
    }
}
