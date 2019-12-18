using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];
        ChessPiece c;
        int y;
        // White team move
        if (isWhite)
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
