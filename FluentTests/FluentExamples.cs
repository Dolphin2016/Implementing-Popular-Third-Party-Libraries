using FluentAssertions;

namespace FluentTests
{
    public class FluentExamples
    {
        [Fact]
        public void TestString()
        {
            string city = "London";
            string expectedCity = "London";

            city.Should().StartWith("Lo")
                .And.EndWith("on")
                .And.Contain("do")
                .And.HaveLength(6);

            city.Should().NotBeNull()
                .And.Be("London")
                .And.BeSameAs(expectedCity)
                .And.BeOfType<string>();

            city.Length.Should().Be(6);
        }

        [Fact]
        public void TestCollections()
        {
            string[] names = new[] { "Alice", "Bob", "Charly" };

            names.Should().HaveCountLessThan(4,
                "because the maximum items should be 3 or fewer");

            names.Should().OnlyContain(name => name.Length <= 6);
        }
    }
}