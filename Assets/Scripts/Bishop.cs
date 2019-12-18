using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece
{
    public override bool [,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        ChessPiece c;
        int y;
        // White team move
        if (isWhite)
        {
            // Right Up  
            for (int x = CurrentX + 1; x < 8; x++)
            {
                y = CurrentY + (x - CurrentX);
                if(y > 7)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x,y] = true;
                }
                else if (!c.isWhite)
                {
                    r[x,y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Right Down
            for (int x = CurrentX + 1; x < 8; x++)
            {
                y = CurrentY - (x - CurrentX);
                if(y < 0)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (!c.isWhite)
                {
                    r[x, y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Left Up
            for (int x = CurrentX - 1; x >= 0; x--)
            {
                y = CurrentY + (CurrentX - x);
                if (y > 7)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (!c.isWhite)
                {
                    r[x, y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Left Down
            for (int x = CurrentX - 1; x >= 0; x--)
            {
                y = CurrentY - (CurrentX - x);
                if (y < 0)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (!c.isWhite)
                {
                    r[x, y] = true;
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
            // Right Up  
            for (int x = CurrentX + 1; x < 8; x++)
            {
                y = CurrentY + (x - CurrentX);
                if (y > 7)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (c.isWhite)
                {
                    r[x, y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Right Down
            for (int x = CurrentX + 1; x < 8; x++)
            {
                y = CurrentY - (x - CurrentX);
                if (y < 0)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (c.isWhite)
                {
                    r[x, y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Left Up
            for (int x = CurrentX - 1; x >= 0; x--)
            {
                y = CurrentY + (CurrentX - x);
                if (y > 7)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (c.isWhite)
                {
                    r[x, y] = true;
                    break;
                }
                else
                {
                    break;
                }
            }
            // Left Down
            for (int x = CurrentX - 1; x >= 0; x--)
            {
                y = CurrentY - (CurrentX - x);
                if (y < 0)
                {
                    break;
                }
                c = BoardManager.Instance.Pieces[x, y];
                if (c == null)
                {
                    r[x, y] = true;
                }
                else if (c.isWhite)
                {
                    r[x, y] = true;
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
