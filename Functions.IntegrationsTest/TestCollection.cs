using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Functions.IntegrationsTest
{
    [CollectionDefinition(nameof(TestCollection))]
    public class TestCollection : ICollectionFixture<TestFixture>
    {
    }
}
