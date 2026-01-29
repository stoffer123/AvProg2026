using Livelearning2_HashCodes;

public class Program
{
    public static void Main(string[] args)
    {
        var person1 = new Person { Fornavn = "John", Efternavn = "Doe" };
        var person2 = new Person { Fornavn = "John", Efternavn = "Doe" };

        var søgePerson = new Person { Fornavn = "", Efternavn = "", Id = person1.Id };


        HashSet<Person> peopleSet = new HashSet<Person>();
        Dictionary<Person, string> peopleDict = new Dictionary<Person, string>();

        peopleSet.Add(person1);
        var result = peopleSet.Contains(person2);

        person1.Efternavn = "Smith";

        result = peopleSet.Contains(søgePerson);


        Console.WriteLine($"Person 1 HashCode: {person1.GetHashCode()}");
        Console.WriteLine($"Person 2 HashCode: {person2.GetHashCode()}");
        Console.WriteLine($"Are they equal? {person1.Equals(person2)}");
    }
}