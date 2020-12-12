using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingClassLibrary.UnitTests
{
    public class PlayerTests
    {
        [Fact]
        public void Should_Create_InstanceOf_NewPlayerName()
        {
            var player = new Player("Salwa");

            Assert.Equal("Salwa", player.Name);
        }

        [Fact]
        public void Should_Create_InstanceOf_NewPlayerScore()
        {
            var player = new Player("Clara");

            Assert.Equal(0, player.Round._personScore);
        }
    }
}
