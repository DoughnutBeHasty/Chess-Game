using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        ChessPiece c;
        // White team move
        if (isWhite)
        {
            // Can move forwards
            if (CurrentY != 7)
            {
                // Try forwards
                c = BoardManager.Instance.Pieces[CurrentX, CurrentY + 1];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX, CurrentY + 1] = true;
                }
                // Try forwards right diagonal
                if (CurrentX != 7)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY + 1];
                    if (c == null || !c.isWhite)
                    {
                        r[CurrentX + 1, CurrentY + 1] = true;
                    }
                }
                // Try forwards left diagonal
                if (CurrentX != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY + 1];
                    if (c == null || !c.isWhite)
                    {
                        r[CurrentX - 1, CurrentY + 1] = true;
                    }
                }
            }
            // Can move backwards
            if (CurrentY != 0)
            {
                // Try backwards
                c = BoardManager.Instance.Pieces[CurrentX, CurrentY - 1];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX, CurrentY - 1] = true;
                }
                // Try backwards right diagonal
                if (CurrentX != 7)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY - 1];
                    if (c == null || !c.isWhite)
                    {
                        r[CurrentX + 1, CurrentY - 1] = true;
                    }
                }
                // Try backwards left diagonal
                if (CurrentX != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY - 1];
                    if (c == null || !c.isWhite)
                    {
                        r[CurrentX - 1, CurrentY - 1] = true;
                    }
                }
            }
            // Can move right
            if (CurrentX != 7)
            {
                c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX + 1, CurrentY] = true;
                }
            }
            // Can move left
            if (CurrentX != 0)
            {
                c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY];
                if (c == null || !c.isWhite)
                {
                    r[CurrentX - 1, CurrentY] = true;
                }
            }
        }
        // Black team move
        else
        {
            // Can move forwards
            if (CurrentY != 0)
            {
                // Try forwards
                c = BoardManager.Instance.Pieces[CurrentX, CurrentY - 1];
                if (c == null || c.isWhite)
                {
                    r[CurrentX, CurrentY - 1] = true;
                }
                // Try forwards right diagonal
                if (CurrentX != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY - 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX - 1, CurrentY - 1] = true;
                    }
                }
                // Try forwards left diagonal
                if (CurrentX != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY - 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX + 1, CurrentY - 1] = true;
                    }
                }
            }
            // Can move backwards
            if (CurrentY != 7)
            {
                // Try backwards
                c = BoardManager.Instance.Pieces[CurrentX, CurrentY + 1];
                if (c == null || c.isWhite)
                {
                    r[CurrentX, CurrentY + 1] = true;
                }
                // Try backwards right diagonal
                if (CurrentX != 0)
                {
                    c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY + 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX - 1, CurrentY + 1] = true;
                    }
                }
                // Try backwards left diagonal
                if (CurrentX != 7)
                {
                    c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY + 1];
                    if (c == null || c.isWhite)
                    {
                        r[CurrentX + 1, CurrentY + 1] = true;
                    }
                }
            }
            // Can move right
            if (CurrentX != 0)
            {
                c = BoardManager.Instance.Pieces[CurrentX - 1, CurrentY];
                if (c == null || c.isWhite)
                {
                    r[CurrentX - 1, CurrentY] = true;
                }
            }
            // Can move left
            if (CurrentX != 7)
            {
                c = BoardManager.Instance.Pieces[CurrentX + 1, CurrentY];
                if (c == null || c.isWhite)
                {
                    r[CurrentX + 1, CurrentY] = true;
                }
            }
        }
        return r;
    }
}
