using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance { set; get; }
    private bool [,] allowedMoves { get; set; }
    private const float tileSize = 1.0f;
    private const float tileOffset = 0.5f;
    private int selectionX = -1;
    private int selectionY = -1;
    public bool isWhiteTurn = true;
    public List<GameObject> chessdudePrefabs;
    public GameObject chessBoard;
    private List<GameObject> activeChessPieces = new List<GameObject>();
    public ChessPiece[,] Pieces { set; get; }
    private ChessPiece selectedChessPiece;
    private void Start()
    {
        Instance = this;
        SpawnAllChessPieces();
        SpawnChessBoard();
    }
    private void Update()
    {
        DrawChessboard();
        UpdateSelection();
        if(Input.GetMouseButtonDown(0))
        {
            if(selectionX >=0 && selectionY >=0)
            {
                if(selectedChessPiece == null)
                {
                    // Select the piece
                    SelectChessPiece(selectionX, selectionY);
                }
                else
                {
                    // Move the piece
                    MoveChessPiece(selectionX, selectionY);                 
                }
            }
        }
    }
    private void SpawnAllChessPieces()
    {
        Pieces = new ChessPiece[8, 8];
        int[,] positions = { { 3, -1 }, { 4, -1 }, { 0, 7 }, { 2, 5 }, { 1, 6 } };
        // Spawn white pieces
        SpawnTeamPieces(positions, true);
        // Spawn black pieces
        SpawnTeamPieces(positions, false);
    }
    private void SelectChessPiece(int x, int y)
    {
        if(Pieces[x,y] == null)
        {
            return;
        }
        if(Pieces[x,y].isWhite != isWhiteTurn)
        {
            return;
        }
        allowedMoves = Pieces[x, y].PossibleMove();
        selectedChessPiece = Pieces[x, y];
        BoardHighlight.Instance.HighlightAllowedMoves(allowedMoves);
    }
    private void MoveChessPiece(int x, int y)
    {
        if (allowedMoves[x, y])
        {
            ChessPiece c = Pieces[x, y];
            if(c != null && c.isWhite != isWhiteTurn)
            {
                // If king
                if (c.GetType() == typeof(King))
                {
                    // End the game
                    return;
                }
                // Capture the piece
                activeChessPieces.Remove(c.gameObject);
                Destroy(c.gameObject);
            }
            Pieces[selectedChessPiece.CurrentX, selectedChessPiece.CurrentY] = null;
            selectedChessPiece.transform.position = GetTileCentre(x, y);
            selectedChessPiece.SetPosition(x, y);
            Pieces[x, y] = selectedChessPiece;
            isWhiteTurn = !isWhiteTurn;
        }
        BoardHighlight.Instance.ResetHighlights();
        selectedChessPiece = null;
    }
    private void SpawnTeamPieces(int[,] positions, bool isWhite)
    {
        // Spawn all non pawn pieces
        int row;
        int j;
        float rotation;
        if (isWhite)
        {
            row = 0;
            rotation = 0.0f;
        }
        else
        {
            row = 7;
            rotation = 180.0f;
        }
        for (int i = 0; i < 5; i++)
        {
            // Sets the prefab index relative to i based on piece colour
            if (isWhite)
            {
                j = i;
            }
            else
            {
                j = i + 6;
            }
            // Array elements containing -1 correspond to unique pieces (King, Queen)
            if (positions[i, 1] == -1)
            {
                SpawnChessPiece(j, positions[i, 0], row, rotation);
            }
            // Other elements have 2 identical pieces to spawn in different locations
            else
            {
                SpawnChessPiece(j, positions[i, 0], row, rotation);
                SpawnChessPiece(j, positions[i, 1], row, rotation);
            }
        }
        // Spawn all pawns
        int prefabIndex;
        if (isWhite)
        {
            row = 1;
            prefabIndex = 5;
            rotation = 0.0f;
        }
        else
        {
            row = 6;
            prefabIndex = 11;
            rotation = 180.0f;
        }
        for (int i = 0; i < 8; i++)
        {
            SpawnChessPiece(prefabIndex, i, row, rotation);
        }
    }
    private void UpdateSelection()
    {
        if(!Camera.main)
        {
            return;
        }
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f,LayerMask.GetMask("ChessPlane")))
        {
            Debug.Log(hit.point);
            selectionX = (int)hit.point.x;
            selectionY = (int)hit.point.z;
        }
        else
        {
            selectionX = -1;
            selectionY = -1;
        }
    }
    private void SpawnChessPiece(int index, int x, int y, float rotation)
    {
        GameObject newSpawn = Instantiate(chessdudePrefabs[index], GetTileCentre(x,y), Quaternion.Euler(0, rotation, 0)) as GameObject;
        Pieces[x, y] = newSpawn.GetComponent<ChessPiece>();
        Pieces[x, y].SetPosition(x, y);
        newSpawn.transform.SetParent(transform);
    }
    private void SpawnChessBoard()
    {
        GameObject spawnBoard = Instantiate(chessBoard);
    }
    private void DrawChessboard()
    {
        Vector3 widthLine = Vector3.right * 8;
        Vector3 heightLine = Vector3.forward * 8;
        for (int i = 0; i < 9; i++)
        {
            Vector3 start = Vector3.forward * i;
            Debug.DrawLine(start, start + widthLine);
            for (int j = 0; j < 9; j++)
            {
                start = Vector3.right * j;
                Debug.DrawLine(start, start + heightLine);
            }
        }
        //Draw the selection
        if(selectionX>=0 && selectionY >=0)
        {
            Debug.DrawLine(Vector3.forward * selectionY + Vector3.right * selectionX, Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));
            Debug.DrawLine(Vector3.forward * (selectionY + 1) + Vector3.right * selectionX, Vector3.forward * selectionY + Vector3.right * (selectionX + 1));
        }
    }
    private Vector3 GetTileCentre(int x, int y)
    {
        Vector3 origin = Vector3.zero;
        origin.x += (tileSize * x) + tileOffset;
        origin.z += (tileSize * y) + tileOffset;
        return origin;
    }
}
