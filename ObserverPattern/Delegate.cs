namespace ObserverPattern;

public  delegate void MyDelegate(string message);

public class Delegate
{
    public static void SayHello(string msg)
    {
        Console.WriteLine("Hello: " + msg);
    }

    // Phương thức 2
    public static void SayGoodbye(string msg)
    {
        Console.WriteLine("Goodbye: " + msg);
    }
}