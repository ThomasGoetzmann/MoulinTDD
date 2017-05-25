using FakeItEasy;
using MoulinTDD;
using MoulinTDD.Exceptions;
using NFluent;
using Xunit;

namespace MoulinTDD_UnitTests
{
    public class PawnUnitTests
    {
        [Theory]
        [InlineData(Color.Black, Color.Black)]
        [InlineData(Color.White, Color.White)]
        public void Pawn_HasValidColor(Color color, Color expectedResult)
        {
            var pawn = new Pawn(color);

            Check.That(pawn.Color).Equals(expectedResult);
        }

        [Fact]
        public void Owner_NotSetYet_Throws()
        {
            var pawn = new Pawn();

            Check.ThatCode(() => pawn.Owner).Throws<InvalidPawnOwnerException>();
        }

        [Fact]
        public void Owner_SetWhitePlayerForBlackPawn_Throws()
        {
            //Arrange
            var fakePlayer = A.Fake<IPlayer>();
            A.CallTo(() => fakePlayer.Color).Returns(Color.White);

            var pawn = new Pawn(Color.Black);

            //Act
            Check.ThatCode(() => pawn.Owner = fakePlayer).Throws<InvalidPawnOwnerException>();
        }
    }
}
