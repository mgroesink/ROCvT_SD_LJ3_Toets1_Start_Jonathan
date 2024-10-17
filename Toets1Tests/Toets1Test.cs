using I1SD_Toets1_Start;

namespace Toets1Tests
{
    public class Toets1Test
    {
        [Fact]
        public void TestHallo()
        {
            var result = MyFunctions.Hallo();
            Assert.Equal("Welkom bij deze ASP-NET / C# toets", result);
        }

        [Fact]
        public void Opdracht1Test13()
        {
            // Arrange
            int input = 13;
            List<int> expectedSequence = new List<int> { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1};

            // Act
            List<int> result = MyFunctions.CreateNumberSequence(input);

            // Assert
            Assert.Equal(expectedSequence, result);
        }

        [Fact]
        public void Opdracht1Test5()
        {
            // Arrange
            int input = 5; 

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => MyFunctions.CreateNumberSequence(input));

            // Verify the exception message
            Assert.Equal("Getal moet groter zijn dan 5", ex.Message);
        }
    }
}