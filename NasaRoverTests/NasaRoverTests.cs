using System;
using Xunit;
using NasaRover;

namespace NasaRoverTests
{
    public class NasaRoverTests
    {
        [Fact]
        public void ScrollLeft()
        {
            //arrange
            RoverMovement movement = new RoverMovement(" 1 2 N");
            //act
            movement.ScrollLeft();
            Console.WriteLine(movement.direction);
            //assert
            Assert.Equal("W", movement.direction);
        }
        [Fact]
        public void ScrollRight()
        {
            //arrange
            RoverMovement movement = new RoverMovement(" 1 2 N");
            //act
            movement.ScrollRight();
            Console.WriteLine(movement.direction);
            //assert
            Assert.Equal("E", movement.direction);
        }
        [Fact]
        public void GoForward()
        {
            //arrange
            RoverMovement movement = new RoverMovement(" 1 2 N");
            //act
            movement.GoForward();
            Console.WriteLine(movement.direction);
            //assert
            Assert.Equal(3, movement.y);
        }
        [Fact]
        public void Navigate()
        {
            //arrange
            RoverMovement movement = new RoverMovement(" 1 2 N");
            //act
            movement.Navigate("LMLMLMLMM");
            Console.WriteLine(movement.direction);
            //assert
            Assert.Equal("1 3 N", movement.x + "" + movement.y + "" + movement.direction);
        }
    }
}
