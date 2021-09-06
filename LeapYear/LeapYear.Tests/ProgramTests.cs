using System;
using Xunit;
using System.IO;

namespace LeapYear.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void isLeapYear_year_from_0_to_99()
        {
             // Arrange
            Program program = new Program();

            // Act
            for(int i = 1; i < 99; i++){
                bool output = program.isLeapYear(i);
                if(i%4 == 0){
                    Assert.Equal(true, output);
                } else {
                    Assert.Equal(false, output);
                }

            }

        }

        [Fact]
        public void isLeapYear_year_100(){
            Program program = new Program();

            bool output = program.isLeapYear(100);

            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_year_400(){
            Program program = new Program();

            bool output = program.isLeapYear(400);

            Assert.Equal(true, output);
        }

    [Fact]
         public void main_enters_leap_year_retruns_yay(){        
            // Arrange
            var reader = new StringReader("1644");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("yay", output);
        }

        [Fact]
         public void main_enters_normal_year_retruns_nay(){
           // Arrange
            var reader = new StringReader("1643");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void vailidInput_year_before_1582(){
            Program program = new Program();

            bool output = program.validInput("100");

            Assert.Equal(false, output);
        }

        [Fact]
        public void vailidInput_year_after_1582(){
            Program program = new Program();

            bool output = program.validInput("1858");

            Assert.Equal(true, output);
        }

        [Fact]
        public void vailidInput_text_input(){
            Program program = new Program();

            bool output = program.validInput("dkfldsfjflk");

            Assert.Equal(false, output);
        }
    }
}
