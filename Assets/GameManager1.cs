using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    int width = 5;
    int height = 8;
    Node[,] nodes;
    public Transform gridCellPrefab;
    private void CreateGrid()
    {
        nodes = new Node[width, height];
        var name = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 worldPosition = new Vector2(i, j);

                Transform obj = Instantiate(gridCellPrefab, worldPosition, Quaternion.identity);
                obj.name = "Cell " + name;
                nodes[i, j] = new Node(true, worldPosition, obj);
                name++;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Node
{
    public bool isPlaceable;
    public Vector2 cellPosition;
    public Transform obj;


    public Node(bool isPlaceable, Vector2 cellPosition, Transform obj)
    {
        this.isPlaceable = isPlaceable;
        this.cellPosition = cellPosition;
        this.obj = obj;
    }
}