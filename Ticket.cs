namespace LR4_
{
    internal class Ticket
    {

        private double _cost = 0;

        public Ticket()
        {
            Cost = 0;
        }
        public Ticket(double cost)
        {
            Cost = cost;
        }

        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Цена не может быть меньше нуля");
                }
                _cost = value;
            }
        }

        public void IncreaseCost(double cost)
        {
            Cost += cost;
        }

        public void DecreaseCost(double cost)
        {
            Cost -= cost;
        }
    }
}
