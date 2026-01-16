

using Opgave2;

Dealer dealer = new Dealer();
List<Kort> deckWithJokers = dealer.getOrderedDeck();

//shuffle the deck multiple times
deckWithJokers = dealer.ShuffleDeck(deckWithJokers);

foreach (Kort kort in deckWithJokers)
{
    Console.WriteLine(kort);
}
Console.WriteLine(deckWithJokers.Count);