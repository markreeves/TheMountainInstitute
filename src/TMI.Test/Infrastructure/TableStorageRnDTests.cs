using FluentAssertions;
using Xunit;

namespace TMI.Test.Infrastructure
{
    public class TableStorageRnDTests
    {
        [Fact]
        public void CheckUnitTestingWorks()
        {
            // Arrange ...
            bool value;

            // Act ...
            value = true;

            // Assert ...
            value.Should().BeTrue();
        }
    }
}
