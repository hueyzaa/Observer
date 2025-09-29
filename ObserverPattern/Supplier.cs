namespace ObserverPattern;

public class Supplier
{
    public string Name { get; private set; }
    private readonly List<Subscriber> _subscribers = new();

    // Sự kiện (Observer pattern .NET style)
    public event EventHandler<NotificationEventArgs>? Notification;

    public Supplier(string name)
    {
        Name = name;
    }

    // Đăng ký
    public void Subscribe(Subscriber subscriber)
    {
        if (!_subscribers.Contains(subscriber))
        {
            _subscribers.Add(subscriber);
            Notification += subscriber.OnNotified;
            Console.WriteLine($"{subscriber.Name} đa đang ky {Name}");
        }
    }

    // Hủy đăng ký (Dissuprier)
    public void Dissuprier(Subscriber subscriber)
    {
        if (_subscribers.Remove(subscriber))
        {
            Notification -= subscriber.OnNotified;
            Console.WriteLine($"{subscriber.Name} đa huy đang ky {Name}");
        }
    }

    // Gửi thông báo
    public void Notify(string message)
    {
        Console.WriteLine($"\n[{Name}] thong bao: {message}");
        Notification?.Invoke(this, new NotificationEventArgs(Name, message));
    
    }
}