namespace ObserverPattern;

public class Subscriber
{
    public string Name { get; private set; }

    public Subscriber(string name)
    {
        Name = name;
    }

    // Xử lý sự kiện
    public void OnNotified(object? sender, NotificationEventArgs e)
    {
        Console.WriteLine($"[{Name}] nhan tu {e.SupplierName}: {e.Message}");
    }
}