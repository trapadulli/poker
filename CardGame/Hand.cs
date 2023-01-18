public class Hand
{
    public Card[] Cards { get; set; }
    public string Category { get; set; }

    public Hand(Card[] cards)
    {
        Cards = cards;
        Category = GetCategory();
    }

    private string GetCategory()
    {
        // Check for pairs
        var pairs = Cards.GroupBy(x => x.Value).Where(x => x.Count() == 2);
        if (pairs.Count() == 1) return "Pair";
        if (pairs.Count() == 2) return "Two Pair";



        // Check for straight
        var sortedCards = Cards.OrderBy(x => x.Value).ToArray();
        bool isStraight = true;
        for (int i = 0; i < 4; i++)
        {
            if (GetValue(sortedCards[i].Value) != GetValue(sortedCards[i + 1].Value) - 1)
            {
                isStraight = false;
                break;
            }
        }
        if (isStraight) return "Straight";

        // Check for flush
        var flush = Cards.GroupBy(x => x.Suit).Where(x => x.Count() == 5);
        if (flush.Count() == 1) return "Flush";

        return "No Category";
    }

    private int GetValue(string value)
    {
        switch (value)
        {
            case "J": return 11;
            case "Q": return 12;
            case "K": return 13;
            case "A": return 14;
            default: return int.Parse(value);
        }
    }
}
