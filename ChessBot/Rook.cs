using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Rook : ChessPiece
    {
        public Rook(int r, int c, bool isW)
        {
            type = "Rook";
            rPos = r;
            cPos = c;
            isWhite = isW;
        }

        public override bool validMove(int rTar, int cTar)
        {
            return true;
        }

        public override void makeMove(int rTar, int cTar)
        {

        }

    }


}
