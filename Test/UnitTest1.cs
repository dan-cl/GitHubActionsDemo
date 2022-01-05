using System;
using GitHubActionsDemo.Services;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var service = new ServiceOne();
            var expected = true;

            //Act
            var result = service.MethodOne(expected);

            //Assert
            Assert.Equal(expected, result);
            
        }
    }
}
