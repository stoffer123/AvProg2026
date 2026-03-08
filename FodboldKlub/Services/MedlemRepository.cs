using FodboldKlub.Models;

namespace FodboldKlub.Services
{
    public class MedlemRepository : IMedlemRepository
    {
        private readonly List<Medlem> _medlemmer = new();

        public IEnumerable<Medlem> HentAlle()
        {
            return _medlemmer.AsEnumerable();
        }

        public Medlem? HentMedID(Guid id)
        {
            return _medlemmer.FirstOrDefault(m => m.Id == id);
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
