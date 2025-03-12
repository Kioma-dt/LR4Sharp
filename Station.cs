using System.Numerics;

namespace LR4_
{
    internal class Station
    {
        private static Station? s_stationInstance = null;
        private string _name;
        private uint _places;
        private uint _soldTickets;
        private Ticket _ticket;        

        private Station(string? name = null, uint places = 0, uint soldTickets = 0, double cost = 0) 
        {
            _name = name ?? String.Empty;
            _places = places;
            _soldTickets = soldTickets;
            _ticket = new Ticket(cost);
        }

        public static Station GetStationInstance(string? name, uint places, uint soldTickets, double cost)
        {
            if (s_stationInstance == null)
                s_stationInstance = new Station(name, places, soldTickets, cost);
            return s_stationInstance;
        }

        public static Station GetStationInstance(string? name, uint places, uint soldTickets)
        {
            if (s_stationInstance == null)
                s_stationInstance = new Station(name, places, soldTickets);
            return s_stationInstance;
        }

        public static Station GetStationInstance(string? name, uint places)
        {
            if (s_stationInstance == null)
                s_stationInstance = new Station(name, places);
            return s_stationInstance;
        }

        public static Station GetStationInstance(string? name)
        {
            if (s_stationInstance == null)
                s_stationInstance = new Station(name);
            return s_stationInstance;
        }

        public static Station GetStationInstance()
        {
            if (s_stationInstance == null)
                s_stationInstance = new Station();
            return s_stationInstance;
        }

        public double GetCostOfRemainTickets() => (_places - _soldTickets) * _ticket.Cost;

        public void IncreaseTicketCost(double cost) => _ticket.IncreaseCost(cost);

        public void DecreaseTicketCost(double cost) => _ticket.DecreaseCost(cost);

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public uint Places
        {
            get => _places;
            private set => _places = value;
        }

        public uint SoldTickets
        {
            get => _soldTickets; 
            private set => _soldTickets = value;
        }

        public double TicketCost 
        {
            get => _ticket.Cost;
            private set => _ticket.Cost = value;
        }
    }
}
