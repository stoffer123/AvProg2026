

using Opgave5.PersonOpgave;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        PersonListe personer = new("C:\\Users\\00529252\\source\\repos\\AvProg2026\\Opgave5\\data\\personer.csv");


        //5.4
        personer.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
        foreach (var item in personer.GetList(p => p.Accepted))
        {
            Console.WriteLine(item.ToString()); ;
            
        };



    }
}