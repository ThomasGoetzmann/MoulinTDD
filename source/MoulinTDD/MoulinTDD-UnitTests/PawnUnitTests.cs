using NUnit.Framework;
using MoulinTDD;
using FakeItEasy;
using MoulinTDD.Exceptions;
using NFluent;
using System;

namespace MoulinTDD_UnitTests
{
    [TestFixture]
    public class PawnUnitTests
    {
        [Test]
        [TestCase(Color.Black, ExpectedResult = Color.Black)]
        [TestCase(Color.White, ExpectedResult = Color.White)]
        public Color Pawn_HasValidColor(Color color)
        {
            var pawn = new Pawn(color);

            return pawn.Color;
        }

        [Test]
        public void Owner_NotSetYet_Throws()
        {
            var pawn = new Pawn();

            Check.ThatCode(() => pawn.Owner).Throws<InvalidPawnOwnerException>();
        }

        [Test]
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
