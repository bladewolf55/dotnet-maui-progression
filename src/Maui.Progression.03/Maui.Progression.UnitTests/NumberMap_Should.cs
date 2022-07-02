using Maui.Progression.Domain.Models;


namespace Maui.Progression.UnitTests;

public class NumberMap_Should
{
    [Fact]
    public void Return_words_for_numbers()
    {
        // arrange
        var map = new NumberMap();

        // act
        map.Map = new List<NumberMapItem>()
        {
            new NumberMapItem() { Number = 0, Word = "zero"},
            new NumberMapItem() { Number = 1, Word = "one"},
            new NumberMapItem() { Number = 2, Word = "two"},
            new NumberMapItem() { Number = 3, Word = "three"},
            new NumberMapItem() { Number = 4, Word = "four"},
            new NumberMapItem() { Number = 5, Word = "five"},
            new NumberMapItem() { Number = 6, Word = "six"},
            new NumberMapItem() { Number = 7, Word = "seven"},
            new NumberMapItem() { Number = 8, Word = "eight"},
            new NumberMapItem() { Number = 9, Word = "nine"},
            new NumberMapItem() { Number = 10, Word ="ten"}
        };

        // assert
        Assert.Equal("zero", map.ToWord(0));
        Assert.Equal("one",  map.ToWord(1));
        Assert.Equal("two",  map.ToWord(2));
        Assert.Equal("three",map.ToWord(3));
        Assert.Equal("four", map.ToWord(4));
        Assert.Equal("five", map.ToWord(5));
        Assert.Equal("six",  map.ToWord(6));
        Assert.Equal("seven",map.ToWord(7));
        Assert.Equal("eight",map.ToWord(8));
        Assert.Equal("nine", map.ToWord(9));
        Assert.Equal("ten",  map.ToWord(10));
    }

    [Fact]
    public void Return_null_if_number_not_found()
    {
        // arrange
        var map = new NumberMap();

        // act
        // assert
        Assert.Empty(map.Map);
        Assert.Null(map.ToWord(0));

    }
}


