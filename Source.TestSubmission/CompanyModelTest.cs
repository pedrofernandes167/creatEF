﻿using Codenation.Challenge.Models;
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
