using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardHighlight : MonoBehaviour
{
    public static BoardHighlight Instance { get; set; }
    public GameObject highlightPrefab;
    public List<GameObject> highlights;
    private void Start()
    {
        Instance = this;
        highlights = new List<GameObject>();
    }
    private GameObject GetHighlightObject()
    {
        GameObject spawn = highlights.Find(g => !g.activeSelf);
        if(spawn == null)
        {
            spawn = Instantiate(highlightPrefab);
        }
        highlights.Add(spawn);
        return spawn;
    }
    public void HighlightAllowedMoves(bool[,] moves)
    {
        for(int i=0;i<8;i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if(moves[i,j])
                {
                    GameObject spawn = GetHighlightObject();
                    spawn.SetActive(true);
                    spawn.transform.position = new Vector3(i + 0.5f, 0, j + 0.5f);
                }
            }
        }
    }
    public void ResetHighlights()
    {
        foreach (var spawn in highlights)
        {
            spawn.SetActive(false);
        }
    }
}
