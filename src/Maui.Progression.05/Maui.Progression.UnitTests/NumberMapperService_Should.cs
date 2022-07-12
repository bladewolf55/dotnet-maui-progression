using Maui.Progression.DomainServices;

namespace Maui.Progression.UnitTests;

public class NumberMapperService_Should
{
    readonly NumberMapper numberMapper;

    // This would normally be an injectable data service
    // such as Entity Framework. We'd use an in-memory database
    // to mock our data access.
    readonly string numberData = @"[
{""number"":1, ""word"":""one""},
{""number"":3, ""word"":""three""},
{""number"":5, ""word"":""five""}
]";

    public NumberMapperService_Should()
    {        
        numberMapper = new NumberMapper(numberData);
    }

    [Fact]
    public void Return_a_populated_NumberMap()
    {
        // arrange
        // act
        var result = numberMapper.GetNumberMap();

        // assert
        Assert.NotEmpty(result.Map);
        Assert.Equal(3, result.Map.Count);
        Assert.Equal("one", result.ToWord(1));
        Assert.Equal("three", result.ToWord(3));
        Assert.Equal("five", result.ToWord(5));
    }
}
