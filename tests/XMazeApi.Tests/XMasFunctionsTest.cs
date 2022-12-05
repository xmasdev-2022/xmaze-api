using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Moq;

namespace XMazeApi.Tests
{
    public class XMasFunctionsTest
    {
        [Theory]
        [InlineData("", typeof(BadRequestResult))]
        [InlineData("Giorgio", typeof(OkObjectResult))]

        public async Task DefaultFunctionTest(string queryParam, Type expectedResult)
        {
            // Arrange
            var qc = new QueryCollection(new Dictionary<string, StringValues> { { "name", new StringValues(queryParam) } });
            var request = new Mock<HttpRequest>();
            request.Setup(x => x.Query)
                .Returns(() => qc);

            var logger = Mock.Of<ILogger>();

            // Act
            var response = await XMasFunctions.RunDefaultFunction(request.Object, logger);

            // Assert
            Assert.True(response.GetType() == expectedResult);
        }

        [Theory]
        [InlineData("", typeof(BadRequestResult))]
        [InlineData("Giorgio", typeof(OkObjectResult))]

        public async Task XMasTotalPackagesTest(string queryParam, Type expectedResult)
        {
            // Arrange
            var qc = new QueryCollection(new Dictionary<string, StringValues> { { "name", new StringValues(queryParam) } });
            var request = new Mock<HttpRequest>();
            request.Setup(x => x.Query)
                .Returns(() => qc);

            var logger = Mock.Of<ILogger>();

            // Act
            var response = await XMasFunctions.RunDefaultFunction(request.Object, logger);

            // Assert
            Assert.True(response.GetType() == expectedResult);
        }
    }
}