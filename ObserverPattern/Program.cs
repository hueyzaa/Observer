namespace ObserverPattern;

class Program
{
    static void Main(string[] args)
    {
        var supplierA = new Supplier("Supplier-A");
        var supplierB = new Supplier("Supplier-B");

        var alice = new Subscriber("Alice");
        var bob = new Subscriber("Bob");
        var charlie = new Subscriber("Charlie");
        
        MyDelegate d1 = Delegate.SayHello;
        MyDelegate d2 = Delegate.SayGoodbye;
        
        // Đăng ký
        supplierA.Subscribe(alice);
        supplierA.Subscribe(bob);

        supplierB.Subscribe(bob);
        supplierB.Subscribe(charlie);

        // Gửi thông báo
        supplierA.Notify("Hang mai da ve.");
        supplierB.Notify("Khuyen mai cuoi tuan!");

        // Bob hủy đăng ký khỏi SupplierA
        supplierA.Dissuprier(bob);

        supplierA.Notify("Chi con 10 san pham cuoi cung.");
    }
}
