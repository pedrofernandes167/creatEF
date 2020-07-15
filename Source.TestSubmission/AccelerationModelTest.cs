using Codenation.Challenge.Models;
using Xunit;

namespace Codenation.Challenge
{
    public sealed class AccelerationModelTest : ModelBaseTest
    {
        public AccelerationModelTest() : base(new CodenationContext())
        {
            Model = "Codenation.Challenge.Models.Acceleration";
            Table = "acceleration";
        }

        [Fact]
        public void Should_Has_Table()
        {
            AssertTable();
        }
    }
}
