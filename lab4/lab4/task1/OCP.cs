public class NotificationService
{
    public void SendNotification(string type, string message)
    {
        if (type == "Email")
        {
            Console.WriteLine("Sending Email: " + message);
        }
        else if (type == "SMS")
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }
}
