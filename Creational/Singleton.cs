namespace design_patterns.Creational.Singleton;

public class Singleton
{
    private static Singleton? _instance;
    // private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside
    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            // You can uncomment the lock for thread safety if needed
            // lock (_lock)
            // {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            // }
        }
        return _instance;
    }
}