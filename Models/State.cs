namespace DeliveryToPostamt.Models
{
    public enum State
    {
        Registered=1,
        Accepted,
        Issued,
        DeliveredToTheCheckPoint,
        DeliveredToTheRecipient,
        Canceled
    }
}