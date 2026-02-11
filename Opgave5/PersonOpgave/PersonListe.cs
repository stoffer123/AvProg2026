using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5.PersonOpgave
{
    public class PersonListe
    {
        private List<Person> liste;

        public PersonListe(string filePath)
        {
            liste = Person.CreatePersonListFromCSV(filePath);
        }

        public List<Person> GetScoresBelow2()
        {
            var result = from p in liste
                         where p.Score < 2
                         select p;

            return result.ToList();

        }

        public List<Person> GetEvenScores()
        {
            var result = from p in liste
                         where p.Score % 2 == 0
                         select p;

            return result.ToList();
        }

        public List<Person> GetEvenScoresAndWeightOver60()
        {
            var result = GetEvenScores().Where(p => p.Weight > 60);

            return result.ToList();
        }

        public List<Person> GetDivisibleByThree()
        {
            var result = from p in liste
                         where p.Weight % 3 == 0
                         select p;

            return result.ToList();
        }

        public ReadOnlyCollection<Person> GetList(Predicate<Person> predicate = null)
        {
            if(predicate == null)
            {
                return liste.AsReadOnly();
            }

            return liste.Where(p => predicate(p)).ToList().AsReadOnly();
        }

        public void SetAccepted(Predicate<Person> predicate)
        {
            foreach(Person p in liste)
            {
                if(predicate(p))
                {
                    p.Accepted = true;
                }
            }
            
        }
    }
}
