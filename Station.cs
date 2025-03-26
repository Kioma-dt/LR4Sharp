namespace LR4_
{
    internal class Station
    {
        private static Station? _instance;
        private string? _name;
        private uint _places;
        private uint _soldTickets;
        private Ticket _ticket;

        private Station()
        {
            Name = String.Empty;
            Places = 0;
            SoldTickets = 0;
            _ticket = new Ticket();
        }

        public static Station GetInstance()
        {
            _instance ??= new Station();
            return _instance;
        }

        public double GetCostOfRemainTickets() => (Places - SoldTickets) * TicketCost;

        public void IncreaseTicketCost(double cost) => _ticket.IncreaseCost(cost);

        public void DecreaseTicketCost(double cost) => _ticket.DecreaseCost(cost);

        public void SetData(string? name, uint places, uint soldTickets, double cost)
        {
            string? tempName = Name;
            uint tempPlaces = Places;
            uint tempSoldTickets = SoldTickets;
            double tempTicketCost = TicketCost;
            try
            {
                Name = name ?? String.Empty;
                Places = places;
                SoldTickets = soldTickets;
                TicketCost = cost;
            }
            catch (Exception ex){
                this.SetData(tempName, tempPlaces , tempSoldTickets, tempTicketCost);
                throw new Exception(ex.Message);
            }
        }

        public string? Name
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
            private set
            {
                if (value > Places)
                {
                    throw new Exception("Количество проданных билетов не может быть больше мест");
                }
                _soldTickets = value;
            }
        }

        public double TicketCost
        {
            get => _ticket.Cost;
            private set => _ticket.Cost = value;
        }
    }
}
