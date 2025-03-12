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
                Console.Write("Насколько вы хотите уменьшить цену: ");
                double decrese = CheckDecrese(station.TicketCost);
                station.DecreaseTicketCost(decrese);
            }
            else
            {
                Console.Write("Насколько вы хотите увеличить цену: ");
                double increse = CheckUDouble();
                station.IncreaseTicketCost(increse);
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

        public static void SetData(out string? name, out uint places, out uint soldTickets, out double cost)
        {
            Console.Write("Введите название станции: ");
            name = Console.ReadLine();
            Console.Write("Введите количество мест: ");
            places = Methods.CheckUInt();
            Console.Write("Введите количество проданных билетов: ");
            soldTickets = Methods.CheckSoldTickets(places);
            Console.Write("Введите стоимость билет: ");
            cost = Methods.CheckUDouble();
        }

        public static double CheckUDouble()
        {
            double number = 0d;
            bool isDouble = false;
            string? s = String.Empty;

            while (!isDouble)
            {
                s = Console.ReadLine();
                isDouble = Double.TryParse(s, out number) && number >= 0;
                if (!isDouble)
                {
                    Console.Write("Неверный формат ввода! Необходимо ввести неотрицательное число: ");
                }
            }

            return number;
        }

        public static uint CheckUInt()
        {
            uint number = 0;
            bool isUInt = false;
            string? s = String.Empty;

            while (!isUInt)
            {
                s = Console.ReadLine();
                isUInt = UInt32.TryParse(s, out number);
                if (!isUInt)
                {
                    Console.Write("Неверный формат ввода! Необходимо ввести целое неотрицательное число: ");
                }
            }

            return number;
        }

        public static uint CheckSoldTickets(uint places)
        {
            uint soldTickets = 0;
            bool rightSold = false;

            while (!rightSold)
            {
                soldTickets = CheckUInt();
                rightSold = soldTickets <= places;
                if (!rightSold)
                {
                    Console.Write("Количество проданных билетов не может быть больше мест! Введите верное количество: ");
                }
            }

            return soldTickets;
        }

        public static double CheckDecrese(double cost)
        {
            double decrese = 0d;
            bool rightDecrese = false;

            while (!rightDecrese)
            {
                decrese = CheckUDouble();
                rightDecrese = decrese <= cost;
                if (!rightDecrese)
                {
                    Console.Write("Уменьшение стоимости билета больше изначльной стоимости! Введите верное уменьшение: ");
                }
            }

            return decrese;
        }
    }
}
