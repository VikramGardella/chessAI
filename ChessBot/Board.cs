using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBot
{
    public class Board
    {
        //Member Variables
        Space[,] spaces = new Space[8, 8];
        bool whiteTurn;

        //Constructor
        public Board()
        {
            whiteTurn = true;
            for(int r = 0; r < 8; r++)
            {
                for(int c=0; c<8; c++)
                {
                    if (r == 0)
                    {//black special pieces
                        if(c == 0 || c == 7)
                        {
                            spaces[r, c] = new Space(new Rook(r, c, false));
                        }
                        if (c == 1 || c == 6)
                        {
                            spaces[r, c] = new Space(new Knight(r, c, false));
                        }
                        if (c == 2 || c == 5)
                        {
                            spaces[r, c] = new Space(new Bishop(r, c, false));
                        }
                        if (c == 3)
                        {//"Queen on her color...
                            spaces[r, c] = new Space(new Queen(r, c, false));
                        }
                        if (c == 4)
                        {
                            spaces[r, c] = new Space(new King(r, c, false));
                        }
                    }
                    else if(r == 1)
                    {//black pawns
                        spaces[r, c] = new Space(new Pawn(r, c, false));
                    }
                    else if(r == 6)
                    {//white pawns
                        spaces[r, c] = new Space(new Pawn(r, c, true));
                    }
                    else if(r == 7)
                    {//white special pieces
                        if (c == 0 || c == 7)
                        {
                            spaces[r, c] = new Space(new Rook(r, c, true));
                        }
                        if (c == 1 || c == 6)
                        {
                            spaces[r, c] = new Space(new Knight(r, c, true));
                        }
                        if (c == 2 || c == 5)
                        {
                            spaces[r, c] = new Space(new Bishop(r, c, true));
                        }
                        if (c == 3)
                        {//"Queen on her color...
                            spaces[r, c] = new Space(new Queen(r, c, true));
                        }
                        if (c == 4)
                        {
                            spaces[r, c] = new Space(new King(r, c, true));
                        }
                    }
                    else
                    {
                        spaces[r, c] = new Space(false);
                    }
                }
            }
        }


        //Accessors
        public string getSpaceValue(int r, int c)
        {
            return spaces[r, c].getPieceType();
        }

        //Mutators
        public void setSpaceValue(int r, int c, string value)
        {
            spaces[r, c].setPieceType(value);
        }

        //Misc. Functions
        public void printBoard()
        {
            for(int r = 0; r < 8; r++)
            {
                for(int c=0; c < 8; c++)
                {
                    Console.Write(spaces[r, c].getPieceType() + "\t");
                }
                Console.WriteLine();
            }

        }

    }
}
