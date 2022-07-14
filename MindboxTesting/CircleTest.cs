using System;
using System.Threading.Tasks;
using MindboxTest;
using Xunit;

namespace MindboxTesting
{
    public class CircleTest
    {
        [Fact]
        public async Task TestCalculateWithEmptyRadius()
        {
            // Arrange
            var circle = new Circle();
            
            var exception = await Assert.ThrowsAsync<ShapeException>( async () =>
            {
                // Act
                await AreaCalculator.Calculate(circle);
            });
                    
            // Assert
            Assert.Equal(new Circle().GetType(), exception.ShapeType);
            
            
            // Assert
            Assert.Equal("Radius is null", exception.Message);

        }

        [Fact]
        public async Task TestCalculateWithCorrectRadius()
        {
            for (int j = 0; j < 100000; j++)
            {
                // Arrange
                
                var radiusValueR = new Random(DateTime.Now.Millisecond);
                var radiusValue = radiusValueR.Next(100, 10001);
                    
                
                var circle = new Circle{Radius = radiusValue};
            
                //Act 
                var result =await AreaCalculator.Calculate(circle);

                //Assert
                Assert.NotEqual(1,result);
                //Assert
                Assert.NotEqual(double.MinValue,result);
            }
        }
    }
}