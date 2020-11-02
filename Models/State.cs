namespace DeliveryToPostamt.Models
{
    public class State
    {
        public int Id { get; set; }
        public int Name { get; set; }
        //Registered = 1,
        // Accepted,
        // Issued,
        // DeliveredToTheCheckPoint,
        // DeliveredToTheRecipient,
        // Canceled
    }
}