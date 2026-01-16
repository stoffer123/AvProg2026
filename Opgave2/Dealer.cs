using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Opgave2
{
    internal class Dealer
    {
        private readonly List<Kort> _deck;

        public Dealer()
        {
            _deck = new List<Kort>();
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
                    _deck.Add(new Kort(kulør, rang));
                }
            }
        }


        public List<Kort> getOrderedDeckWithJokers()
        {
            List<Kort> returDeck = new(_deck.ToList());

            // Tilføj fire jokere til bunken
            returDeck.Add(new Kort(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(new Kort(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(new Kort(EKulør.INGEN, ERang.JOKER));
            returDeck.Add(new Kort(EKulør.INGEN, ERang.JOKER));

            return returDeck;
        }

        public List<Kort> getOrderedDeck()
        {
            return new List<Kort>(_deck.ToList());
        }

        public List<Kort> ShuffleDeck(List<Kort> deck)
        {
            Random rand = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                int k = rand.Next(n--); //sæt k til et tilfældigt tal under n, herefter decrement n

                //byt kortene ved position n og k
                Kort temp = deck[n]; 
                deck[n] = deck[k]; 
                deck[k] = temp;
            }
            return deck;
        }

    }
}
