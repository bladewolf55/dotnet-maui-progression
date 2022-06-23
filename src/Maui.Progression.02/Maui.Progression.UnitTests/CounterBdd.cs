using Machine.Specifications;
using Maui.Progression.ViewModels;

namespace Maui.Progression.UnitTests;

[Subject("Scoring")]
public class When_increasing_counter_by_command
{
    static Counter? subject;

    Establish context = () =>
        subject = new Counter();

    Because of = () =>
        subject.IncreaseCounterCommand.Execute(null);

    It should_increase_count_by_one = () =>
        subject.Count.ShouldEqual(1);
}


public class When_initializing_Counter
{
    static Counter? subject;

    Establish context = () =>
        subject = new Counter();

    It should_start_at_zero = () =>
        subject.Count.ShouldEqual(0);
}