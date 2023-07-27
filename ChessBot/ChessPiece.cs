using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public abstract class ChessPiece
    {
        public string type;
        public int rPos;
        public int cPos;
        public bool isWhite;

        //Accessors
        public string getPieceType() { return type; }


        //Mutators
        public void setPieceType(string newType) { type = newType; }


        public abstract bool validMove(int rTar, int cTar);
        public abstract void makeMove(int rTar, int cTar);


    }


}
