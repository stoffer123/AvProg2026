// See https://aka.ms/new-console-template for more information
using DataProcessor.Client;

public class Program
{
    public static void Main(string[] args)
    {
        Client client = new Client();

        client.Run();
    }
}