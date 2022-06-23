using Maui.Progression.ViewModels;

namespace Maui.Progression.UnitTests;

public class Counter_Should
{
    [Fact]
    public void Increment_counter_by_one_using_command()
    {
        // arrange
        int expected = 1;
        var vm = new Counter();

        // verify the starting count
        Assert.True(vm.Count == 0, "Starting count should have been zero.");

        // act
        vm.IncreaseCounterCommand.Execute(null);

        // assert
        Assert.Equal(expected, vm.Count);
    }
}
