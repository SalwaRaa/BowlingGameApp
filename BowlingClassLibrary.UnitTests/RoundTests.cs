using System;
using Xunit;

namespace BowlingClassLibrary.UnitTests
{
    public class RoundTests
    {
        private Round r;

        public RoundTests()
        {
            r = new Round();
        }

        [Fact]
        public void Test_Bowling_Round_Class()
        {
            Assert.IsType<Round>(r);
        }

        private void should_Roll_Many(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                r.Roll(pins);
            }
        }
       
        [Fact]
        public void Should_Roll_Gutter()
        {
            should_Roll_Many(20, 0);
            Assert.Equal(0, r.Score());
        }

        [Fact]
        public void Should_Roll_Only_Ones()
        {
            should_Roll_Many(20, 1);
            Assert.Equal(20, r.Score());
        }
        
      

    }
}
