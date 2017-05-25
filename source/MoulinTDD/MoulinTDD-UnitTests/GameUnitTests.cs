using FakeItEasy;
using MoulinTDD;
using NFluent;
using System.Linq;
using Xunit;

namespace MoulinTDD_UnitTests
{

    public class GameUnitTests
    {
        [Fact]
        public void Game_Has9WhitePawns()
        {
            var game = new Game();

            var whitePawnsAmount = game.Pawns.Count(p => p.Color == Color.White);

            Check.That(whitePawnsAmount).IsEqualTo(9);
        }

        [Fact]
        public void Game_Has9BlackPawns()
        {
            var game = new Game();

            var blackPawnsAmount = game.Pawns.Count(p => p.Color == Color.Black);

            Check.That(blackPawnsAmount).IsEqualTo(9);
        }

        [Fact]
        public void Game_Has2Players()
        {
            var game = new Game();

            Check.That(game.Player1).HasFieldsWithSameValues(new Player());
            Check.That(game.Player2).HasFieldsWithSameValues(new Player());
        }
    }
}
