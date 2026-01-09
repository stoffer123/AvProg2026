

using Øvelse1;

public static class Program
{
    public static void Main(string[] args)
    {
        MedarbejderListe<Adresse, IHarAdresse> medarbejderListe = new MedarbejderListe<Adresse, IHarAdresse>();

        Medarbejder medarbejder1 = new Mekaniker(
                "Hans Hansen",
                new Adresse
                {
                    Vejnavn = "Hovedgaden",
                    Nummer = 2,
                    By = "Somecity",
                    Postnummer = "4321"
                },
                new CprNr("010101", "1234"),
                "87654321",
                new DateTime(2020, 6, 1),
                200m
            );

        Firma firma = new Firma(new Adresse
        {
            Vejnavn = "Hovedgaden",
            Nummer = 1,
            By = "Somecity",
            Postnummer = "4321"
        });

        try
        {
            medarbejderListe.AddElement(medarbejder1.Adresse, medarbejder1);
            //medarbejderListe.AddElement(medarbejder1.CprNr, medarbejder1);
            medarbejderListe.AddElement(firma.Adresse, firma);

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(medarbejderListe.GetElement(new Adresse
        {
            Vejnavn = "Hovedgaden",
            Nummer = 2,
            By = "Somecity",
            Postnummer = "4321"
        }));

    }
}