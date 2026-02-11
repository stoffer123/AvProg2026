using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5.PersonOpgave
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }

        public Person(string data)
        {
            string[] splitArr = data.Split(';');
            Name = splitArr[0];
            Age = int.Parse(splitArr[1]);
            Weight = int.Parse(splitArr[2]);
            Score = int.Parse(splitArr[3]);
            Accepted = false;
        }

        //Metode til at skabe en Liste af personer fra en .CSV
        public static List<Person> CreatePersonListFromCSV(string filename)
        {
            List<Person> list = new();
            using (var file = new StreamReader(filename))
            {
                string line;
                while((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                }
            }

            return list;
        }

        public override string ToString()
        {
            return $"Name: {Name} \n" +
                $"Age: {Age} \n" +
                $"Weight: {Weight} \n" +
                $"Score: {Score} \n" +
                $"Accepted: {Accepted} \n";
        }
    }
}
