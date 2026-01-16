using Opgave2.Factories;
using Opgave2.Kort;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Opgave2
{
    internal class Dealer<TKort> where TKort : IKort
    {
        private readonly List<TKort> _deck;
        private readonly IKortFactory<TKort> _kortFactory;

        public Dealer(IKortFactory<TKort> kortFactory)
        {
            _deck = new List<TKort>();
            _kortFactory = kortFactory;
            
            foreach (EKulør kulør in Enum.GetValues(typeof(EKulør)))
            {
                if(kulør == EKulør.INGEN)
                {
                    continue; // Ingen kulør skippes, kun jokere har ingen kulør
                }
                foreach (ERang rang in Enum.GetValues(typeof(ERang)))
                {
                    if(rang == ERang.JOKER)
                    {
                        continue; // Jokeren skippes og tilføjes til sidst
                    }
                    _deck.Add(_kortFactory.Create(kulør, rang));
                }
            }
        }


        public List<TKort> getOrderedDeckWithJokers()
        {
            List<TKort> returDeck = new(_deck.ToList());

            // Tilføj fire jokere til bunken
            returDeck.Add(_kortFactory.Create(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(_kortFactory.Create(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(_kortFactory.Create(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(_kortFactory.Create(EKulør.INGEN, ERang.JOKER));

            return returDeck;
        }

        public List<TKort> getOrderedDeck()
        {
            return new List<TKort>(_deck.ToList());
        }

        public List<TKort> ShuffleDeck(List<TKort> deck)
        {
            Random rand = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                int k = rand.Next(n--); //sæt k til et tilfældigt tal under n, herefter decrement n

                //byt kortene ved position n og k
                TKort temp = deck[n]; 
                deck[n] = deck[k]; 
                deck[k] = temp;
            }
            return deck;
        }

        public List<TKort> FilterDeck(FilterKortDelegate<TKort> filter)
        {
            List<TKort> result = new();

            foreach(TKort kort in _deck)
            {
                if(filter(kort))
                {
                    result.Add(kort);
                }
            }

            return result;
        }

    }
}
