using CardGame.Test.TestModels;
namespace CardGame.Test;

public class UnitTest1
{
    [Fact]
    public void Test_0100_IsStraight()
    {
        var hand = HandCategory.BuildLowStraight();
        Assert.Equal("Straight", hand.Category);
    }

    [Fact]
    public void Test_0200_IsFlush()
    {
        var hand = HandCategory.BuildLowFlush("Diamonds");
        Assert.Equal("Flush", hand.Category);
    }

    [Fact]
    public void Test_0300_IsPair()
    {
        var hand = HandCategory.BuildPair();
        Assert.Equal("Pair", hand.Category);
    }

    [Fact]
    public void Test_0400_IsTwoPair()
    {

        var hand = HandCategory.BuildTwoPair();
        Assert.Equal("Two Pair", hand.Category);
    }

    [Fact]
    public void Test_0500_FushHighBeatsLow()
    {
        var lowHand = HandCategory.BuildLowFlush("Diamonds");
        var highHand = HandCategory.BuildHighFlush("Clubs");
        Assert.True(lowHand.CardScore < highHand.CardScore);
    }

    [Fact]
    public void Test_0600_StraightHighBeatsLow()
    {
        var lowHand = HandCategory.BuildLowStraight();
        var highHand = HandCategory.BuildHighStraight();
        Assert.True(lowHand.CardScore < highHand.CardScore);
    }

    [Fact]
    public void Test_0600_CategoryBeatsCategory()
    {
        var highHand = HandCategory.BuildTwoPair();
        var lowHand = HandCategory.BuildPair();
        Assert.True(lowHand.CategoryScore < highHand.CategoryScore);
        highHand = HandCategory.BuildLowStraight();
        lowHand = HandCategory.BuildTwoPair();
        Assert.True(lowHand.CategoryScore < highHand.CategoryScore);
        highHand = HandCategory.BuildHighFlush("Clubs");
        lowHand = HandCategory.BuildLowStraight();
        Assert.True(lowHand.CategoryScore < highHand.CategoryScore);
    }
}