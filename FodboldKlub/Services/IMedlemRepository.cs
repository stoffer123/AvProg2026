using FodboldKlub.Models;

namespace FodboldKlub.Services
{
    public interface IMedlemRepository
    {
        IEnumerable<Medlem> HentAlle();
        Medlem? HentMedID(Guid id);
        void Tilføj(Medlem medlem);
        void Slet(Guid id);
        void Opdater(Medlem medlem);
    }
}
