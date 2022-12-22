using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class howToPlay : MonoBehaviour
{
    GameObject block1;
    string str;
    int result;
    Text tx;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        str = tx.text;
        Debug.Log(str);        
        if (collision.gameObject.name[0] == block1.name[0])
        {

            

            collision.gameObject.GetComponent<Image>().color = new Color32(195, 52, 80,255);
            
            
            Destroy(block1);
            Debug.Log(str);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
