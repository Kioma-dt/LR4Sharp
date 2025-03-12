using System.Numerics;
using System.Xml.Linq;

namespace LR4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = String.Empty;
            double cost = 0d;
            uint places = 0, soldTickets = 0;
            Methods.SetData(out name, out places, out soldTickets, out cost);
            Station station = Station.GetStationInstance(name, places, soldTickets, cost);

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine(new String('-', 30));
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine("1 - Информация о станции");
                Console.WriteLine("2 - Стоимость непроданных билетов");
                Console.WriteLine("3 - Изменение цены билета");
                Console.WriteLine("4 - Выход");

                string? answer = Console.ReadLine();
                Console.WriteLine(new String('-', 30));
                switch (answer)
                {
                    case "1":
                        Methods.GetData(station);
                        break;
                    case "2":
                        Methods.CountCost(station);
                        break;
                    case "3":
                        Methods.ChangeCost(station);
                        break;
                    case "4":
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
