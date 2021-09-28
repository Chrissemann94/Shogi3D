// 3D Game Grids in Unity Tutorial: https://www.youtube.com/watch?v=qkSSdqOAAl4
// Added to: Tile

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    private int height = 9;
    private int width = 9;

    [SerializeField] private GameObject tilePrefab;
    private GameObject[,] board;


    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateGrid()
    {
        board = new GameObject[width, height];

        if (tilePrefab == null)
        {
            Debug.LogError("ERROR: Grid Tile Prefab on the Game grid is not assigned");
            return;
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                board[x, y] = Instantiate(tilePrefab, new Vector3(x, 0, y), Quaternion.identity);
                board[x, y].transform.parent = transform;
                board[x, y].gameObject.name = $"Tile(X: {x.ToString()} Y: {y.ToString()})";

            }
        }
    }
}
