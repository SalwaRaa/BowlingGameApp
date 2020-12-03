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

        private void Should_Roll_Spare()
        {
            r.Roll(6);
            r.Roll(4);
        }

        [Fact]
        public void Should_Roll_OneSpare()
        {
            Should_Roll_Spare();
            r.Roll(4);
            should_Roll_Many(17, 0);
            Assert.Equal(18, r.Score());
        }

        [Fact]
        public void Should_Roll_OneStrike()
        {
            r.Roll(10);
            r.Roll(4);
            r.Roll(5);
            should_Roll_Many(17, 0);
            Assert.Equal(28, r.Score());
        }

        [Fact]
        public void Should_Roll_Perfect_Game()
        {
            should_Roll_Many(12, 10);
            Assert.Equal(300, r.Score());
        }

    }
}
