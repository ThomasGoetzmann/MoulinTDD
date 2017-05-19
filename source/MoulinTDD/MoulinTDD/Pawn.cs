using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoulinTDD
{
    public class Pawn
    {
        private PawnColor black;

        public Pawn(PawnColor color)
        {
            Color = color;
        }

        public PawnColor Color { get; private set; }
    }
}
