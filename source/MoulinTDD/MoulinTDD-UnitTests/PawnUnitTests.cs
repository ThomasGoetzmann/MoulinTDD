using System;
using NUnit;
using NUnit.Framework;
using MoulinTDD;

namespace MoulinTDD_UnitTests
{
    [TestFixture]
    public class PawnUnitTests
    {
        [Test]
        [TestCase(PawnColor.Black, ExpectedResult = PawnColor.Black)]
        [TestCase(PawnColor.White, ExpectedResult = PawnColor.White)]
        public PawnColor Pawn_HasValidColor(PawnColor color)
        {
            var pawn = new Pawn(color);

            return pawn.Color;
        }
    }
}
