using FodboldKlub.Models;

namespace FodboldKlub.Services
{
    public class MedlemRepository : IMedlemRepository
    {
        private readonly List<Medlem> _medlemmer = new();

        public MedlemRepository()
        {

            //Test medlemmer: 

            _medlemmer.Add(new Medlem()
            {
                Id = Guid.NewGuid(),
                Fornavn = "Sten",
                Efternavn = "Flintstone",
                Adresse = "Flintevej 62, 1234 Stenløse",
                Email = "Flintstone@stonemail.com",
                Telefon = "12345678"
            });

            _medlemmer.Add(new Medlem()
            {
                Id = Guid.NewGuid(),
                Fornavn = "Lars",
                Efternavn = "Tyndskid",
                Adresse = "Lars mark, 4321 PåLandet",
                Email = "tyndskid@langtude.dk",
                Telefon = "87654321"
            });
        }

        public IEnumerable<Medlem> HentAlle()
        {
            return _medlemmer.AsEnumerable();
        }

        public Medlem? HentMedID(Guid id)
        {
            return _medlemmer.FirstOrDefault(m => m.Id == id);
        }

        public void Opdater(Medlem medlem)
        {
            var eksisterende = HentMedID(medlem.Id);

            if(eksisterende != null)
            {
                eksisterende.Fornavn = medlem.Fornavn;
                eksisterende.Efternavn = medlem.Efternavn;
                eksisterende.Adresse = medlem.Adresse;
                eksisterende.Telefon = medlem.Telefon;
                eksisterende.Email = medlem.Email;
            }
        }

        public void Slet(Guid id)
        {
            var medlem = HentMedID(id);
            if(medlem != null)
            {
                _medlemmer.Remove(medlem);
            }
        }

        public void Tilføj(Medlem medlem)
        {
                medlem.Id = Guid.NewGuid();
                _medlemmer.Add(medlem);
        }
    }
}
