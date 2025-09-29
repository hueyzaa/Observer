namespace ObserverPattern;

public class NotificationEventArgs : EventArgs
{
    public string SupplierName { get; }
    public string Message { get; }

    public NotificationEventArgs(string supplierName, string message)
    {
        SupplierName = supplierName;
        Message = message;
    }
}