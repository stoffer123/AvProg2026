using System;
using System.Collections.Generic;
using System.Text;

namespace Øvelse1
{
    internal class MedarbejderListe<TKey, TValue> where TValue : IHarAdresse
    {
        private Dictionary<TKey, TValue> _medarbejdere = new Dictionary<TKey, TValue>();


        /// <summary>
        /// Tilføjer en medarbejder til listen.
        /// </summary>
        /// <param name="k">Nøglen der identificerer medarbejderen.</param>
        /// <param name="v">Medarbejderen der skal tilføjes.</param>
        /// <exception cref="ArgumentException">Kastes hvis nøglen allerede findes i listen.</exception>
        public void AddElement(TKey k, TValue v)
        {
            _medarbejdere.Add(k, v);
        }


        /// <summary>
        /// Henter en medarbejder fra listen.
        /// </summary>
        /// <param name="k">Nøglen der identificerer medarbejderen.</param>
        /// <returns>Medarbejderen med den angivne nøgle, eller null hvis ikke fundet.</returns>
        public TValue? GetElement(TKey k)
        {
            //Denne kunne også bare være TryGetValue men jeg syntes det er pænere med en catch her.
            _medarbejdere.TryGetValue(k, out TValue? medarbejder);

            return medarbejder;
        }


        /// <summary>
        /// Returnerer antallet af medarbejdere i listen.
        /// </summary>
        /// <returns>Antal medarbejdere i listen.</returns>
        public int Size()
        {
            return _medarbejdere.Count;
        }
    }
}
