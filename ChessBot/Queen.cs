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
            if (rTar <= 7 && cTar <= 7 && rTar >= 0 && cTar >= 0)
            {
                if ((Math.Abs(rTar - rPos) != 0 && Math.Abs(cTar - cPos) != 0) && (Math.Abs(rTar - rPos) == Math.Abs(cTar - cPos)))
                {
                    return true;
                }
                else if ((Math.Abs(rTar - rPos) == 0 && Math.Abs(cTar - cPos) != 0) || (Math.Abs(rTar - rPos) != 0 && Math.Abs(cTar - cPos) == 0))
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

        }

    }


}
