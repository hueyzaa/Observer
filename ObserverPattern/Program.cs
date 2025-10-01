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
        // Gọi delegate
        d1("Alice");
        
        supplierA.Subscribe(bob);
        d1("bob");    
        supplierB.Subscribe(bob);
        d1("bob"); 
        supplierB.Subscribe(charlie);
        d1("Charlie"); 

        // Gửi thông báo
        supplierA.Notify("Hang mai da ve.");
        supplierB.Notify("Khuyen mai cuoi tuan!");

        // Bob hủy đăng ký khỏi SupplierA
        supplierA.Dissuprier(bob);
        //Delegate goodbye
        d2("Bob");
        supplierA.Notify("Chi con 10 san pham cuoi cung.");
        


        // Multicast delegate (gộp nhiều method)
        MyDelegate d3 = d1 + d2;
        d3("Charlie");
    }
}
