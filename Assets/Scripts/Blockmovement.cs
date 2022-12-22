using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blockmovement : MonoBehaviour
{
    
    Vector3 mousePositionOffset;
    Transform parentAfterDrag;
    int ID;
    GameScript gm;
    Rigidbody2D block;
    public string destinationTag = "DropArea";
    int counter = 0;
    public bool x = false;
    public bool yy = false;
    string sc;
    // Start is called before the first frame update
    void Start()
    {
        ID = GetInstanceID();
        block = GetComponent<Rigidbody2D>();
        block.bodyType = RigidbodyType2D.Dynamic;
        
        gm = GameObject.Find("GameManager").GetComponent<GameScript>();
        
    }
    Vector3 GetMouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);

    }
    public bool mouseUp=false;
    private void OnMouseDrag()
    {
      transform.position = GetMouseWorldPosition() + mousePositionOffset;
        block.bodyType = RigidbodyType2D.Dynamic;
        
    }


    private void OnMouseDown()
    {

        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
        
        block.bodyType = RigidbodyType2D.Static;
        mouseUp = false;

    }

    private void OnMouseUp()
    {
        mouseUp = true;
    }

  

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        x = false;
        string gameObjectName = gameObject.name.Substring(0,name.IndexOf("("));
        string collObjectName = collision.gameObject.name.Substring(0, name.IndexOf("("));
        
        
        if (gameObjectName == collObjectName && gameObjectName == "2")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("4"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();            
        }
        else if (gameObjectName == collObjectName && gameObjectName == "4")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("8"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "8")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("16"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "16")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("32"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "32")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("64"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "64")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("128"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "128")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("256"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "256")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("512"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "512")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("1024"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        else if (gameObjectName == collObjectName && gameObjectName == "1024")
        {
            if (ID < collision.gameObject.GetComponent<Blockmovement>().ID) { return; }
            Instantiate(Resources.Load("2048"), (Vector2)transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            mouseUp = false;
            counter += 10;
            ScoreScript.Instance.AddPoint();
        }
        
        else if (gameObjectName != collObjectName && mouseUp && collision.gameObject.CompareTag("Player"))
        {

            print("sffgv;osfnvoidanfvoi[adfv");

            GameObject[] blocks = GameObject.FindGameObjectsWithTag("Player");
            foreach(var b in blocks)
            {
                print(b.name);
                b.transform.Translate(new Vector2(0.0f, 1.5f));
                
            }
            gm.spawn(true);
        }
        else if(gameObjectName != collObjectName && mouseUp && collision.gameObject.CompareTag("GameOver"))
        {
            gm.GameOverFunc();
        }
    }

  
    // Update is called once per frame
    void Update()
    {
        

    }
}
