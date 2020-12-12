using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingClassLibrary.UnitTests
{
    public class BowlingGameTests
    {
       private BowlingGame game;

            public BowlingGameTests()
            {
                List<string> palyerNames = new List<string> { "Salwa", "Rim" };
                game = new BowlingGame(palyerNames);
            }

        [Fact]
        public void Should_Roll_Strike__ChangeActivePlayer()
        {
            game.Roll(10);

            Assert.Equal("Rim", game._currentPlayer.Name);
        }
        [Fact]
        public void Should_Roll_One_NotChangeActivePlayer()
        {
            game.Roll(1);

            Assert.Equal("Salwa", game._currentPlayer.Name);
        }
        [Fact]
        public void Should_Roll_Twice_ChanceActivePlayer()
        {
            game.Roll(1);
            game.Roll(2);

            Assert.Equal("Rim", game._currentPlayer.Name);
        }
    }
    }

