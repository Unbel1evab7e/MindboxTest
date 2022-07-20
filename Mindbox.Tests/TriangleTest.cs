using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mindbox.Library;
using Xunit;

namespace Mindbox.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void TestNotInitTriangleSides()
        {
            // Arrange
            var triangle = new Triangle();
            
            var exception =  Assert.Throws<ShapeException>( () =>
            {
                // Act
                 AreaCalculator.Calculate(triangle);
            });
            
            // Assert
            Assert.Equal(triangle.GetType(), exception.ShapeType);
            
            
            // Assert
            Assert.Equal("Sides not initialized", exception.Message);
        }
        [Fact]
        public void TestRandomTriangleSides()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // Arrange
                var sidesCountR = new Random(DateTime.Now.Millisecond);
                var sidesCount = sidesCountR.Next(1, 101);
                var sides = new List<int>();
                
                
                for (int j = 0; j < sidesCount; j++)
                {
                    var sideValueR = new Random(DateTime.Now.Millisecond);
                    var sidesValue = sideValueR.Next(1, 101);
                    sides.Add(sidesValue);
                }
                if (sides.Count != 3)
                {
                    var exception = Assert.Throws<ShapeException>( () =>
                    {
                        // Act
                        var triangle = new Triangle{Sides = sides.ToArray()};
                    });
                    
                    // Assert
                    Assert.Equal(new Triangle().GetType(), exception.ShapeType);
            
            
                    // Assert
                    Assert.Equal("Sides count don`t match to this shape", exception.Message);
                }

                else
                {
                    // Act
                    var triangle = new Triangle{Sides = sides.ToArray()};
                    // Assert
                    Assert.NotNull(triangle);
                }
            }
        }

        [Fact]
        public void TestWithCorrectSidesCount()
        {
            for (int j = 0; j < 100000; j++)
            {
                // Arrange
                var sides = new List<int>();
                for (int i = 0; i < (int)ShapesEnum.TriangleSidesCount; i++)
                {
                    var sideValueR = new Random(DateTime.Now.Millisecond);
                    var sidesValue = sideValueR.Next(100, 10001);
                    sides.Add(sidesValue);
                }
                var triangle = new Triangle{Sides = sides.ToArray()};
            
                //Act 
                var result = AreaCalculator.Calculate(triangle);

                //Assert
                Assert.NotEqual(1,result);
                //Assert
                Assert.NotEqual(double.MinValue,result);
            }
        }
    }
}