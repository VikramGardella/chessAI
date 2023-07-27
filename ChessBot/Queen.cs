using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Queen : ChessPiece
    {
        public Queen(int r, int c, bool isW)
        {
            type = "Queen";
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
