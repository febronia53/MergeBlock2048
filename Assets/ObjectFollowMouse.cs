using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollowMouse : MonoBehaviour
{
    placeObjectWorld placeObjectWorld;
    public bool isOnGrid;
    // Start is called before the first frame update
    void Start()
    {
        placeObjectWorld = FindObjectOfType<placeObjectWorld>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOnGrid)
        {
            transform.position = placeObjectWorld.smoothMousePosition = new Vector3(0, 0.1f, 0);
        }
    }
}
