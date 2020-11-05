namespace DeliveryToPostamt.Models
{
    public class Postamat
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public bool State { get; set; }

        public Postamat(int Id, string Address, bool State)
        {
            this.Id = Id;
            this.Address = Address;
            this.State = State;
        }     
    }
}
