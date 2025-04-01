

// Interface định nghĩa contract
public interface IMessageService
{
    string GetMessage();
}

// Class triển khai interface
public class EmailService : IMessageService
{
    public string GetMessage()
    {
        return "Đây là tin nhắn từ Email Service";
    }
}

// Class khác triển khai cùng interface
public class SMSService : IMessageService
{
    public string GetMessage()
    {
        return "Đây là tin nhắn từ SMS Service";
    }
}

// Class sử dụng dependency
public class NotificationManager
{
    private readonly IMessageService _messageService;

    // Constructor injection
    public NotificationManager(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void SendNotification()
    {
        var message = _messageService.GetMessage();
        Console.WriteLine($"Đang gửi thông báo: {message}");
    }
}

// Chương trình chính
internal class Program
{
    private static void Main(string[] args)
    {
        // Tạo instance của service cụ thể
        IMessageService emailService = new EmailService();
        IMessageService smsService = new SMSService();

        // Inject dependency vào NotificationManager
        var emailNotification = new NotificationManager(emailService);
        var smsNotification = new NotificationManager(smsService);

        // Sử dụng
        emailNotification.SendNotification();
        smsNotification.SendNotification();
    }
}