using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeObjectWorld : MonoBehaviour
{
    public Transform gridCellPrefab;
    public Transform[] blocks = new Transform[11];

    public Transform mousePrefab;
    Vector3 mousePosition;
    [SerializeField] int height;
    [SerializeField] int width;
    Node[,] nodes;
    Plane plane;
    public Vector3 smoothMousePosition;
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
        plane = new Plane(Vector3.up, transform.position);
    }

    
    // Update is called once per frame
    void Update()
    {
        GetMousePositionOnGrid();
    }

    public void OnMouseClickOnUI()
    {
        if(mousePrefab == null)
        {
            int randomindex = UnityEngine.Random.Range(0, blocks.Length);
            mousePrefab = Instantiate(blocks[randomindex], transform.position= new Vector3(2.0f, -23.22f, 50.0f), Quaternion.identity);
        }
    }
    double distancebetween2(float x1, float x2, float y1, float y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }
    void GetMousePositionOnGrid()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Node closest_node = null;
        Vector3 closest_hello = new Vector3();
        double closest_distance = 1000;
        if (plane.Raycast(ray,out float enter)) //
        {
            if (Input.GetMouseButtonDown(0))
            {
                mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//ray.GetPoint(enter);
                //smoothMousePosition = mousePosition;
                //mousePosition.z = 0;
                //mousePosition = Vector3Int.RoundToInt(mousePosition);
                int i = 0;
                foreach (var node in nodes)
                {
                    /*print(node.cellPosition == mousePosition);
                    print(mousePosition);
                    print(node.cellPosition);
                    print(node.isPlaceable);
                    print("==========================================================");*/
                    if (distancebetween2(node.cellPosition.x, mousePosition.x, node.cellPosition.y, mousePosition.y) < closest_distance)
                    {
                        closest_node = node;
                        closest_hello = node.obj.position;
                        closest_distance = distancebetween2(node.cellPosition.x, mousePosition.x, node.cellPosition.y, mousePosition.y);
                        //print(distancebetween2(node.cellPosition.x, mousePosition.x, node.cellPosition.y, mousePosition.y));
                        //print("============");
                    }
                    /*if(node.cellPosition == mousePosition && node.isPlaceable)
                    {
                        if (Input.GetMouseButtonUp(0))
                        {
                            node.isPlaceable = false;
                        }
                    }*/
                    i++;
                }
                print(mousePosition);
                print(closest_hello);
                print(closest_distance);
                print("===========================");
            }
        }
    }

    private void CreateGrid()
    {
        nodes = new Node[width, height];
        var name = 0;
        for(int i = 0;i < width; i++)
        {
            for(int j = 0; j<height;j++)
            {
                Vector3 worldPosition = new Vector3(i, j,0);
               
                Transform obj = Instantiate(gridCellPrefab, worldPosition, Quaternion.identity);
                obj.name = "Cell " + name;
                nodes[i, j] = new Node(true, worldPosition, obj);
                name++;
            }
        }
    }

}


