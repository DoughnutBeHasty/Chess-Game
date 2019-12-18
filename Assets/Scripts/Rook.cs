using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Rook : ChessPiece
{
    public override bool [,] PossibleMove()
    {
        bool[,] r = new bool[8,8];
        ChessPiece c;
        // White team move
        if(isWhite)
        {
            // Horizontal right
            for (int h = CurrentX + 1; h < 8; h++)
            {
                c = BoardManager.Instance.Pieces[h, CurrentY];
                if (c == null)
                {
                    r[h, CurrentY] = true;
                }
                else if (!c.isWhite)
                {
                    r[h, CurrentY] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Horizontal left
            for (int h = CurrentX - 1; h >= 0; h--)
            {
                c = BoardManager.Instance.Pieces[h, CurrentY];
                if (c == null)
                {
                    r[h, CurrentY] = true;
                }
                else if (!c.isWhite)
                {
                    r[h, CurrentY] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Vertical up
            for (int v = CurrentY + 1; v < 8; v++)
            {
                c = BoardManager.Instance.Pieces[CurrentX, v];
                if (c == null)
                {
                    r[CurrentX, v] = true;
                }
                else if(!c.isWhite)
                {
                    r[CurrentX, v] = true;
                    break;                
                }
                else
                {
                    break;
                }
            }
            // Vertical down
            for (int v = CurrentY - 1; v >= 0; v--)
            {
                c = BoardManager.Instance.Pieces[CurrentX, v];
                if (c == null)
                {
                    r[CurrentX, v] = true;
                }
                else if (!c.isWhite)
                {
                    r[CurrentX, v] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        // Black team move
        else
        {
            // Horizontal right
            for (int h = CurrentX + 1; h < 8; h++)
            {
                c = BoardManager.Instance.Pieces[h, CurrentY];
                if (c == null)
                {
                    r[h, CurrentY] = true;
                }
                else if (c.isWhite)
                {
                    r[h, CurrentY] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Horizontal left
            for (int h = CurrentX - 1; h >= 0; h--)
            {
                c = BoardManager.Instance.Pieces[h, CurrentY];
                if (c == null)
                {
                    r[h, CurrentY] = true;
                }
                else if (c.isWhite)
                {
                    r[h, CurrentY] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Vertical up
            for (int v = CurrentY + 1; v < 8; v++)
            {
                c = BoardManager.Instance.Pieces[CurrentX, v];
                if (c == null)
                {
                    r[CurrentX, v] = true;
                }
                else if (c.isWhite)
                {
                    r[CurrentX, v] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Vertical down
            for (int v = CurrentY - 1; v >= 0; v--)
            {
                c = BoardManager.Instance.Pieces[CurrentX, v];
                if (c == null)
                {
                    r[CurrentX, v] = true;
                }
                else if (c.isWhite)
                {
                    r[CurrentX, v] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        return r;
    }
}
