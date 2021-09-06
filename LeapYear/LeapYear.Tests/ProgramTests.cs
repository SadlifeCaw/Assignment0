using System;
using Xunit;

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
    }
}
