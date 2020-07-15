using Codenation.Challenge.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Codenation.Challenge
{
    public sealed class CompanyModelTest : ModelBaseTest
    {
        public CompanyModelTest() : base(new CodenationContext())
        {
            Model = "Codenation.Challenge.Models.Company";
            Table = "company";
        }

        [Fact]
        public void Should_Has_Table()
        {
            AssertTable();
        }
    }
}
