namespace design_patterns.Creational.Singleton;

public class Client
{
    public void Execute()
    {
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        if (singleton1 == singleton2)
        {
            Console.WriteLine("Both instances are the same. Singleton works!");
        }
        else
        {
            Console.WriteLine("Instances are different. Singleton failed!");
        }
    }
}