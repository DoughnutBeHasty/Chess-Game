using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        ChessPiece c;
        // White team move
        if (isWhite)
        {
            // Forward right
            if (CurrentX != 7 && CurrentY < 6)
            {
                c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY + 2];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX + 1, CurrentY + 2] = true;
                }
            }
            // Forward left
            if (CurrentX != 0 && CurrentY < 6)
            {
                c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY + 2];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX - 1, CurrentY + 2] = true;
                }
            }
            // Right forward
            if (CurrentX < 6 && CurrentY != 7)
            {
                c = BoardManager.Instance.Pieces[CurrentX + 2, CurrentY + 1];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX + 2, CurrentY + 1] = true;
                }
            }
            // Left forward
            if (CurrentX > 1 && CurrentY != 7)
            {
                c = BoardManager.Instance.Pieces[CurrentX - 2, CurrentY + 1];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX - 2, CurrentY + 1] = true;
                }
            }
        }
        // Black team move
        else
        {
            {
                // Forward right
                if (CurrentX != 0 && CurrentY > 2)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY - 2];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX - 1, CurrentY - 2] = true;
                    }
                }
                // Forward left
                if (CurrentX != 7 && CurrentY > 2)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY - 2];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX + 1, CurrentY - 2] = true;
                    }
                }
                // Right forward
                if (CurrentX > 1 && CurrentY != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 2, CurrentY - 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX - 2, CurrentY - 1] = true;
                    }
                }
                // Left forward
                if (CurrentX < 6 && CurrentY != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 2, CurrentY - 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX + 2, CurrentY - 1] = true;
                    }
                }
            }
        }
        return r;
    }
}
