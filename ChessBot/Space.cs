using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Space
    {
        string occupant;
        bool occupied;

        public Space(ChessPiece occ)
        {
            occupant = occ.getPieceType();
            occupied = true;
        }

        public Space(bool hasPiece)
        {
            occupied = hasPiece;
            occupant = "empty";
        }

        public string getPieceType() { return occupant; }

        public void setPieceType(string pieceType) { occupant = pieceType; }

    }
}
