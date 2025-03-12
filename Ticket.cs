namespace LR4_
{
    internal class Ticket
    {

        private double _cost;

        public Ticket()
        {
            _cost = 0;
        }
        public Ticket(double cost)
        {
            _cost = cost;
        }

        public double Cost
        {
            get => _cost;
            set => _cost = value;
        }

        public void IncreaseCost(double cost) 
        {
            _cost += cost;  
        }

        public void DecreaseCost(double cost)
        {
            if (cost > _cost)
            {
                _cost = 0;
            }
            else
            {
                _cost -= cost;
            }
        }
    }
}
