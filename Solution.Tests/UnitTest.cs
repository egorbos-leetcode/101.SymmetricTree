namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        Assert.True(Solution.IsSymmetric(Solution.BuildTree([1, 2, 2, 3, 4, 4, 3])));
        Assert.False(Solution.IsSymmetric(Solution.BuildTree([1, 2, 2, null, 3, null, 3])));
    }
}