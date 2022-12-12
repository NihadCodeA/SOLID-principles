namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INotification> notificationList = new List<INotification>();

            notificationList.Add(new Email());
            notificationList.Add(new Whatsapp());
            notificationList.Add(new SMS());

            MessageSender messageSender = new MessageSender(notificationList);

            messageSender.Send();

        }
    }
}