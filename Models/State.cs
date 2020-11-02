namespace DeliveryToPostamt.Models
{
    public enum State
    {
        Registered,
        Accepted,
        Issued,
        DeliveredToTheCheckPoint,
        DeliveredToTheRecipient,
        Canceled
    }
}