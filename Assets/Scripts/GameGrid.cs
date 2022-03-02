using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    public int height;
    public int width;
    private float GridSpaceSize = -2f;
    private GameObject[,] gameGrid;

    [SerializeField] private GameObject gridCellPrefab;
    // Start is called before the first frame update
    void Start()
    {

        CreateGrid();
    }


    private void CreateGrid()
    {
        gameGrid = new GameObject[height, width];
        if (gridCellPrefab == null)
        {
            Debug.LogError("Error: Grid Cell Prefab on the Game grid is not assigned");
            return;

        }

        // Make the Grid

        for (int z = 0; z < height; z++)
        {
            for (int x = 0; x < width; x++)
            {
                // create a new GridSpace object for each cell
                gameGrid[x, z] = Instantiate(gridCellPrefab, new Vector3(x * GridSpaceSize, 0, z * GridSpaceSize), Quaternion.identity);
                //gameGrid[x, z].transform.parent = transform;
                //gameGrid[x, z].transform.name = "Grid Space( X: " + x.ToString() + ", Y: " + z.ToString() + ")";
            }
        }
    }
}
