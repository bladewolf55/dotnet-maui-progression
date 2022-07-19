using Maui.Progression.ViewModels;
using FluentAssertions;
using NSubstitute;
using Maui.Progression.DomainServices.Interfaces;
using Maui.Progression.Domain.Models;

namespace Maui.Progression.UnitTests;

public class Counter_Should
{
    readonly INumberMapper numberMapperService;
    Counter? counter;

    public Counter_Should()
    {
        // Mock the service interface. We want to control the domain model it returns.
        numberMapperService = Substitute.For<INumberMapper>();
    }

    [Fact]
    public void Increment_counter_by_one_using_command()
    {
        // arrange
        int expectedNumber = 1;
        string expectedWord = "one";
        NumberMap map = new()
        {
            Map = new List<NumberMapItem>()
            {
                new NumberMapItem() { Number = expectedNumber, Word = expectedWord }
            }
        };
        numberMapperService.GetNumberMap().Returns(map);

        // Inject the service into the view model
        counter = new Counter(numberMapperService);

        // verify the starting count
        counter.Count.Should().Be(0, "starting count should have been zero.");

        // act
        counter.IncreaseCounterCommand.Execute(null);

        // assert
        counter.Count.Should().Be(expectedNumber);
        counter.CountText.Should().Contain(expectedWord);
    }
}
