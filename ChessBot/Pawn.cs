using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Pawn : ChessPiece
    {
        public bool firstMove;
        public Pawn(int r, int c, bool isW)
        {
            type = "Pawn";
            rPos = r;
            cPos = c;
            isWhite = isW;
            firstMove = true;
        }

        public override bool validMove(int rTar, int cTar)
        {
            if (rTar <= 7 && cTar <= 7 && rTar >= 0 && cTar >= 0)
            {
                if ((rPos - rTar) == 1 && Math.Abs(cTar - cPos) == 0 && isWhite)
                {
                    return true;
                }
                else if ((rTar - rPos) == 1 && Math.Abs(cTar - cPos) == 0 && !isWhite)
                {
                    return true;
                }
                else if ((rPos - rTar) == 2 && Math.Abs(cTar - cPos) == 0 && isWhite && firstMove)
                {
                    return true;
                }
                else if ((rTar - rPos) == 2 && Math.Abs(cTar - cPos) == 0 && !isWhite && firstMove)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override void makeMove(int rTar, int cTar)
        {
            firstMove = false;
        }

    }


}
