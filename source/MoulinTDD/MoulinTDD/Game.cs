using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoulinTDD
{
    public class Game
    {
        public Game()
        {
            InitializePawns();
            InitializePlayers();
        }

        private void InitializePlayers()
        {
            Player1 = new Player();
            Player2 = new Player();
        }

        private void InitializePawns()
        {
            Pawns = new List<Pawn>
            {
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),
                new Pawn(Color.Black),

                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
                new Pawn(Color.White),
            };
        }

        public IEnumerable<Pawn> Pawns { get; set; }
        public IPlayer Player1 { get; private set; }
        public IPlayer Player2 { get; private set; }
    }
}
