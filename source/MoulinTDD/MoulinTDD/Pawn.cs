using MoulinTDD.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoulinTDD
{
    public class Pawn
    {
        public Pawn(Color color = Color.Black)
        {
            Color = color;
        }

        public Color Color { get; private set; }
        public IPlayer Owner
        {
            get
            {
                if (owner == null)
                    throw new InvalidPawnOwnerException("No owner set yet for this pawn.");
                return owner;
            }
            set
            {
                if (value.Color != Color)
                {
                    throw new InvalidPawnOwnerException($"Pawn is {Color.ToString()} whereas player '{value?.Name}' chose the {value?.Color} pawns.");
                }
                owner = value;
            }
        }

        private IPlayer owner;
    }
}
