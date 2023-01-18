public class Hand
{
    public Card[] Cards { get; set; }
    public string Category { get; set; }
    public int CategoryScore { get; set; }
    public int CardScore { get; set; }
    
    public Hand(Card[] cards)
    {
       
        Cards = cards;
        Category = GetCategory();
        CategoryScore = Category == "Pair" ? 1 :
                        Category == "Two Pair" ? 2 :
                        Category == "Straight" ? 3 :
                        Category == "Flush" ? 4 : 0;
        
    }
    
    private string GetCategory()
    {
        int[] arry = new int[5];
        for (int i = 0; i < Cards.Length; i++)
        {
            arry[i] = Cards[i].Value == "J" ? 11 :
                      Cards[i].Value == "Q" ? 12 :
                      Cards[i].Value == "K" ? 13 :
                      Cards[i].Value == "A" ? 14 : int.Parse(Cards[i].Value);
         }

        // Check for pairs
        var pairs = Cards.GroupBy(x => x.Value).Where(x => x.Count() == 2);
        var helper = new CardGame.Helper();
        foreach (var pair in pairs)
        {
            CardScore =+ pair.Select(x => helper.Converter[x.Value]).Sum();

        }
        if (pairs.Count() == 1) return "Pair";
        if (pairs.Count() == 2) return "Two Pair";

            

        // Check for straight
        var sortedCards = arry.OrderBy(x => x).ToArray();
        bool isStraight = true;
        for (int i = 0; i < 4; i++)
        {
            if (sortedCards[i] != sortedCards[i + 1] - 1)
            {
                isStraight = false;
                break;
            }
        }
        if (isStraight)
        {
            CardScore = sortedCards.Sum();
            return "Straight";
        }                                                                

        // Check for flush
        var flush = Cards.GroupBy(x => x.Suit).Where(x => x.Count() == 5);
        if (flush.Count() == 1)
        {
            CardScore = sortedCards.Sum();
            return "Flush";
        }
        
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
