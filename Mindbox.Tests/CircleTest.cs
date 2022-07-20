using System;
using System.Threading.Tasks;
using Mindbox.Library;
using Xunit;

namespace Mindbox.Tests
{
    public class CircleTest
    {
        [Fact]
        public void TestCalculateWithEmptyRadius()
        {
            // Arrange
            var circle = new Circle();
            
            var exception = Assert.Throws<ShapeException>(  () =>
            {
                // Act
                 AreaCalculator.Calculate(circle);
            });
                    
            // Assert
            Assert.Equal(new Circle().GetType(), exception.ShapeType);
            
            
            // Assert
            Assert.Equal("Radius is null", exception.Message);

        }

        [Fact]
        public void TestCalculateWithCorrectRadius()
        {
            for (int j = 0; j < 100000; j++)
            {
                // Arrange
                
                var radiusValueR = new Random(DateTime.Now.Millisecond);
                var radiusValue = radiusValueR.Next(100, 10001);
                    
                
                var circle = new Circle{Radius = radiusValue};
            
                //Act 
                var result =AreaCalculator.Calculate(circle);

                //Assert
                Assert.NotEqual(1,result);
                //Assert
                Assert.NotEqual(double.MinValue,result);
            }
        }
    }
}