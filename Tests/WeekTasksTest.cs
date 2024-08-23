
using ConsoleProject;

namespace WeekTasks;

public class WeekTaskTest
{
    [Fact]
    public void TestingGymReturningFullString()
    {
        Tasks task = new Tasks();

        string taskGym = task.Gym();

        Assert.NotEmpty(taskGym);
    }

    [Fact]
    public void TestingGamesReturningFullString()
    {
        Tasks task = new Tasks();

        string taskGames = task.Games();

        Assert.NotEmpty(taskGames);
    }

    [Fact]
    public void TestingStudyReturningFullString()
    {
        Tasks task = new Tasks();

        string taskStudy = task.Study();

        Assert.NotEmpty(taskStudy);
    }

    [Fact]
    public void TestingSoccerReturningFullString()
    {
        Tasks task = new Tasks();

        string taskSoccer = task.Soccer();

        Assert.NotEmpty(taskSoccer);
    }

    [Fact]
    public void TestingHistoryReturningStringList()
    {
        Tasks task = new Tasks();

        List<string> taskHistory = task.HistoryWeek();

        Assert.IsType<List<string>>(taskHistory);
    }
}