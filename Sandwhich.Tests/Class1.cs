using NUnit.Framework;
using Sandwhich.App;

namespace Sandwhich.Tests
{
    [TestFixture]
    public class Adding_Toppings
    {
        [Test]
        public void Clicking_Add_Tomatoes_Adds_Tomatoes_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();

            //Act
            screen.AddTomatoes(2);
            var sandwich = screen.BuildSandwich();

            //Assert
            Assert.AreEqual(2,sandwich.Tomatoes);
        }

        [Test]
        public void Clicking_Add_Tomatoes_Twice_Adds_More_Tomatoes_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();

            //Act
            screen.AddTomatoes(2);
            screen.AddTomatoes(2);
            var sandwich = screen.BuildSandwich();

            //Assert
            Assert.AreEqual(4,sandwich.Tomatoes);
        }

        [Test]
        public void Clicking_Add_Onions_Adds_Onions_To_My_Order()
        {
            //Arrange
            var screen = new SandwichSelectionScreen();

            //Act
            screen.AddOnions();
            var sandwich = screen.BuildSandwich();

            //Assert
            Assert.IsTrue(sandwich.Onions);
        }
    }
}
