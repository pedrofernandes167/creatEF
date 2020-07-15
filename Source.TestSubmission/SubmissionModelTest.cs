using Codenation.Challenge.Models;
using Xunit;

namespace Codenation.Challenge
{
    public sealed class SubmissionModelTest : ModelBaseTest
    {
        public SubmissionModelTest() : base(new CodenationContext())
        {
            Model = "Codenation.Challenge.Models.Submission";
            Table = "submission";
        }

        [Fact]
        public void Should_Has_Table()
        {
            AssertTable();
        }
    }
}
