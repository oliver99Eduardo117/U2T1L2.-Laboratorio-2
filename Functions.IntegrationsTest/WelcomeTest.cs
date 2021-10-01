using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Functions.IntegrationsTest
{
    [Collection(nameof(TestCollection))]
   public class WelcomeTest
    {
        private TestFixture testFixture;
        private HttpResponseMessage httpResponseMessage;

            public WelcomeTest(TestFixture fixture) 
        {
            testFixture = fixture;
        }
        [Fact]
        public async Task WhenfunctioIsInvoked()
        {
            httpResponseMessage = await testFixture.Client.GetAsync("api/Welcome?name=OLIVER");
            Assert.True(httpResponseMessage.IsSuccessStatusCode);
        }
    }
}
